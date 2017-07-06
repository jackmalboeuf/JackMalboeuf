using UnityEngine;
using System.Collections;

public class SlideAway : MonoBehaviour
{
    [SerializeField]
    Vector3 slideDirection;

    public IEnumerator Slide()
    {
        yield return new WaitForSeconds(1);

        while (Vector3.Distance(transform.position, new Vector3(0, 0, 0)) < 5000)
        {
            transform.position += slideDirection;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
