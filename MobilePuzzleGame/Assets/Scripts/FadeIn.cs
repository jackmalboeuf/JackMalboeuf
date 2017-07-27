using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    [SerializeField]
    TileStateManager stage1;

    [HideInInspector]
    public string nextScene;

    Image fadeImage;
    float fadeAmount;
    float startAmount;

    void Start()
    {
        fadeImage = GetComponent<Image>();

        gameObject.SetActive(true);
        StartCoroutine(Fade(-0.08f, 1));
    }

    public IEnumerator Fade(float fadeAmountValue, float startAmountValue)
    {
        fadeAmount = fadeAmountValue;
        startAmount = startAmountValue;

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
        
        if (!string.IsNullOrEmpty(nextScene))
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            gameObject.SetActive(false);
            
            if (stage1 != null)
            {
                stage1.timerIsOn = true;
            }
        }
    }
}
