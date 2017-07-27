using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class RotateTile : MonoBehaviour, IPointerClickHandler
{
    public bool isCorrect;
    public TileStateManager tilesStateManager;

    float waitTime = 0.01f;
    bool canRotate = true;

    void Start()
    {
        if (transform.eulerAngles.z == 0)
            isCorrect = true;
        else
            isCorrect = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(RotateAnimation());
    }

    IEnumerator RotateAnimation()
    {
        if (canRotate)
        {
            canRotate = false;

            transform.SetAsLastSibling();

            for (int i = 0; i < 4; i++)
            {
                transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 18);
                transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));
                yield return new WaitForSeconds(waitTime);
            }

            if (transform.eulerAngles.z >= 300)
                transform.rotation = Quaternion.identity;
            else
                transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 18);

            transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));

            tilesStateManager.numberOfTurns++;

            if (transform.eulerAngles.z == 0)
            {
                isCorrect = true;
                tilesStateManager.CheckIfTilesAreCorrect();
            }
            else
            {
                isCorrect = false;
            }

            canRotate = true;
        }
    }
}
