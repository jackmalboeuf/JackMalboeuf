using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField]
    float fadeAmount;

    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);

        while (image.color.a != 1)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + fadeAmount);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
