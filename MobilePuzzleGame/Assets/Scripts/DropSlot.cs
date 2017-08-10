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
                previousChild.position = previousChild.GetComponent<DragObject>().parentReturn.position;
                previousChild.SetParent(previousChild.GetComponent<DragObject>().parentReturn);
                previousChild.GetComponent<RotateTile>().CheckIfThisTileIsCorrect();
            }
        }
        else if (isBackground)
        {
            d.parentReturn = d.startParent;
            d.transform.position = d.startParent.position;
        }
    }
}
