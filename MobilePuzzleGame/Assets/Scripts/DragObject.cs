using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform startParent;
    public Transform parentReturn;
    public Transform previousParent;

    [HideInInspector]
    public Transform correctParent;
    public static GameObject draggedObject;
    Vector3 startPosition;

    /*[SerializeField]
    AudioSource pickUpSlide;
    [SerializeField]
    AudioSource dropClick;*/

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (GetComponent<RotateTile>())
        {
            GetComponent<RotateTile>().enabled = false;
        }

        //pickUpSlide.Play();
        parentReturn = transform.parent;
        previousParent = transform.parent;
        transform.SetParent(transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        //transform.parent.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //dropClick.Play();
        transform.SetParent(parentReturn);
        transform.position = parentReturn.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (GetComponent<RotateTile>())
        {
            GetComponent<RotateTile>().enabled = true;
            GetComponent<RotateTile>().CheckIfThisTileIsCorrect();
        }
    }
}
