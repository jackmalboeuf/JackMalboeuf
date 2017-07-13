using UnityEngine;
using System.Collections;

public class SlideAway : MonoBehaviour
{
    [SerializeField]
    Transform slideMarker;
    [SerializeField]
    Transform backgroundSlideMarker;
    [SerializeField]
    int slideFrames = 12;

    public IEnumerator Slide()
    {
        yield return new WaitForSeconds(0.3f);

        float travelDistance = Vector2.Distance(backgroundSlideMarker.position, slideMarker.position);
        float travelAmount = travelDistance / slideFrames;

        for (int i = 0; i < slideFrames; i++)
        {
            transform.position += new Vector3(travelAmount, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
