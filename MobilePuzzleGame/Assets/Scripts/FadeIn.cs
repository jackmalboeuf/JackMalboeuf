using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    [SerializeField]
    float fadeAmount;
    [Range(0, 1)]
    [SerializeField]
    float startAmount;

    public string nextScene;

    Image fadeImage;

    void Start()
    {
        fadeImage = GetComponent<Image>();
    }

    public IEnumerator Fade()
    {
        fadeImage = GetComponent<Image>();
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, startAmount);

        int endFade = 0;
        if (startAmount == 1)
            endFade = 0;
        else if (startAmount == 0)
            endFade = 1;

        while (fadeImage.color.a != endFade)
        {
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, fadeImage.color.a + fadeAmount);
            yield return new WaitForSeconds(0.01f);

            if (endFade == 0 && fadeImage.color.a < 0)
                break;
            else if (endFade == 1 && fadeImage.color.a > 1)
                break;
        }

        if (nextScene != null)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
