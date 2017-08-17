using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public bool isBackground;

    public void OnDrop(PointerEventData eventData)
    {
        DragObject d = eventData.pointerDrag.GetComponent<DragObject>();

        if (!isBackground)
        {
            d.parentReturn = transform;
            d.transform.position = transform.position;

            if (transform.childCount > 0)
            {
                Transform previousChild = transform.GetChild(0);
                previousChild.GetComponent<DragObject>().parentReturn = d.previousParent;
                previousChild.SetParent(previousChild.GetComponent<DragObject>().parentReturn);
                previousChild.parent.SetAsLastSibling();
                transform.SetAsLastSibling();
                StartCoroutine(SlideBack(previousChild.position, previousChild.GetComponent<DragObject>().parentReturn.position, previousChild));
            }
        }
        else if (isBackground)
        {
            d.parentReturn = d.startParent;
            d.transform.position = d.startParent.position;
        }
    }

    IEnumerator SlideBack(Vector2 previousPosition, Vector2 newPosition, Transform movingObject)
    {
        float slideFrames = 6;
        float xDistance = newPosition.x - previousPosition.x;
        float xTravelAmount = xDistance / slideFrames;
        float yDistance = newPosition.y - previousPosition.y;
        float yTravelAmount = yDistance / slideFrames;

        for (int i = 0; i < slideFrames; i++)
        {
            movingObject.position += new Vector3(xTravelAmount, yTravelAmount, 0);
            yield return new WaitForSeconds(0.01f);
        }

        movingObject.GetComponent<RotateTile>().CheckIfThisTileIsCorrect();
    }
}
