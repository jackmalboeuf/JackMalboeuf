using UnityEngine;
using System.Collections;

public class SlideAway : MonoBehaviour
{
    [SerializeField]
    Transform slideMarker;
    [SerializeField]
    Transform backgroundSlideMarker;
    [SerializeField]
    FadeIn fadeImage;
    [SerializeField]
    int slideFrames = 12;
    [SerializeField]
    string sceneToLoad;
    [SerializeField]
    ResultsFade resultsTexts;
    [SerializeField]
    TileStateManager nextStage;
    [SerializeField]
    bool setAsFirstSibling = true;

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

        if (setAsFirstSibling)
        {
            transform.SetAsFirstSibling();
        }

        if (nextStage != null)
        {
            nextStage.timerIsOn = true;
        }

        if (fadeImage != null)
        {
            yield return new WaitForSeconds(0.3f);

            fadeImage.gameObject.SetActive(true);
            fadeImage.nextScene = sceneToLoad;
            StartCoroutine(fadeImage.Fade(0.03f, 0));
        }

        if (resultsTexts != null)
        {
            StartCoroutine(resultsTexts.FadeTexts1());
            StartCoroutine(resultsTexts.FadeTexts2());
        }
    }
}
