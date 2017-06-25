using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class RotateTile : MonoBehaviour, IPointerClickHandler
{
    float waitTime = 0.01f;

    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(RotateAnimation());
    }

    IEnumerator RotateAnimation()
    {
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 45);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));
        yield return new WaitForSeconds(waitTime);

        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 30);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));

        yield return new WaitForSeconds(waitTime);

        if (transform.eulerAngles.z >= 300)
            transform.rotation = Quaternion.identity;
        else
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 15);

        transform.eulerAngles = new Vector3(0, 0, Mathf.Round(transform.eulerAngles.z));

        if (transform.eulerAngles.z == 0)
        {
            print("good " + transform.rotation);
        }
    }
}
