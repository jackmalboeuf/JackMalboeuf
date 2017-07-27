using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultsFade : MonoBehaviour
{
    [SerializeField]
    Text[] resultsTexts1 = new Text[6];
    [SerializeField]
    Text[] resultsTexts2 = new Text[6];

    float waitTime = 0.2f;
    float fadeAmount = 0.02f;

    public IEnumerator FadeTexts1()
    {
        AddTotalsText(resultsTexts1);

        for (int i = 0; i < resultsTexts1.Length; i++)
        {
            resultsTexts1[i].color = new Color(resultsTexts1[i].color.r, resultsTexts1[i].color.g, resultsTexts1[i].color.b, 0);
        }

        for (int i = 0; i < resultsTexts1.Length; i++)
        {
            yield return new WaitForSeconds(waitTime);

            StartCoroutine(FadeAnimation(resultsTexts1[i]));
        }
    }

    public IEnumerator FadeTexts2()
    {
        AddTotalsText(resultsTexts2);

        for (int i = 0; i < resultsTexts2.Length; i++)
        {
            resultsTexts2[i].color = new Color(resultsTexts2[i].color.r, resultsTexts2[i].color.g, resultsTexts2[i].color.b, 0);
        }

        for (int i = 0; i < resultsTexts2.Length; i++)
        {
            yield return new WaitForSeconds(waitTime);

            StartCoroutine(FadeAnimation(resultsTexts2[i]));
        }
    }

    IEnumerator FadeAnimation(Text resultsText)
    {
        while (resultsText.color.a < 1)
        {
            resultsText.color = new Color(resultsText.color.r, resultsText.color.g, resultsText.color.b, resultsText.color.a + fadeAmount);
            yield return new WaitForSeconds(0.01f);
        }
    }

    void AddTotalsText(Text[] textArray)
    {
        float totalValue = 0;

        for (int i = 0; i < textArray.Length - 1; i++)
        {
            totalValue += float.Parse(textArray[i].text);
        }

        textArray[textArray.Length - 1].text = totalValue.ToString();
    }
}
