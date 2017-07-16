using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TileStateManager : MonoBehaviour
{
    [HideInInspector]
    public List<RotateTile> tiles = new List<RotateTile>();
    [HideInInspector]
    public List<Image> coloredGoals = new List<Image>();

    List<Image> coloredLines = new List<Image>();
    int numberOfCorrectTiles;

    public void CheckIfTilesAreCorrect()
    {
        numberOfCorrectTiles = 0;

        for (int i = 0; i < tiles.Count; i++)
        {
            if (tiles[i].isCorrect)
            {
                numberOfCorrectTiles++;
            }
        }

        if (numberOfCorrectTiles == tiles.Count)
        {
            StartCoroutine(TilesAllCorrect());
        }
    }

    float IncrementNumber(float startValue, float endValue)
    {
        return Mathf.Abs(startValue - endValue) / 10;
    }

    void FadeColor(int upOrDown)
    {
        float newRValue = 0;
        float newGValue = 0;
        float newBValue = 0;

        for (int i = 0; i < coloredLines.Count; i++)
        {
            newRValue = 0;
            newGValue = 0;
            newBValue = 0;

            Color32 lineColor = coloredLines[i].color;

            if (lineColor.r != 240 && lineColor.g != 240 && lineColor.b == 240)
            {
                newRValue = 0.072f;
                newGValue = 0.04f;
                newBValue = 0;
            }
            else if (lineColor.r != 240 && lineColor.g == 240 && lineColor.b != 240)
            {
                newRValue = 0.072f;
                newGValue = 0;
                newBValue = 0.04f;
            }
            else if (lineColor.r == 240 && lineColor.g != 240 && lineColor.b != 240)
            {
                newRValue = 0;
                newGValue = 0.072f;
                newBValue = 0.04f;
            }

            coloredLines[i].color = new Color(coloredLines[i].color.r + newRValue * upOrDown, coloredLines[i].color.g + newGValue * upOrDown, coloredLines[i].color.b + newBValue * upOrDown);
        }

        for (int h = 0; h < coloredGoals.Count; h++)
        {
            newRValue = 0;
            newGValue = 0;
            newBValue = 0;

            Color32 goalColor = coloredGoals[h].color;

            if (goalColor.r != 240 && goalColor.g != 240 && goalColor.b == 240)
            {
                newRValue = 0.072f;
                newGValue = 0.04f;
                newBValue = 0;
            }
            else if (goalColor.r != 240 && goalColor.g == 240 && goalColor.b != 240)
            {
                newRValue = 0.072f;
                newGValue = 0;
                newBValue = 0.04f;
            }
            else if (goalColor.r == 240 && goalColor.g != 240 && goalColor.b != 240)
            {
                newRValue = 0;
                newGValue = 0.072f;
                newBValue = 0.04f;
            }

            coloredGoals[h].color = new Color(coloredGoals[h].color.r + newRValue * upOrDown, coloredGoals[h].color.g + newGValue * upOrDown, coloredGoals[h].color.b + newBValue * upOrDown);
        }
    }

    /*for (int j = 0; j < tiles.Count; j++)
            {
                tiles[j].GetComponent<Image>().color = new Color(tiles[j].GetComponent<Image>().color.r - 0.03f, tiles[j].GetComponent<Image>().color.g - 0, tiles[j].GetComponent<Image>().color.b - 0);
            }

            backgroundPanel.GetComponent<Image>().color = new Color(backgroundPanel.GetComponent<Image>().color.r - 0.03f, backgroundPanel.GetComponent<Image>().color.g - 0, backgroundPanel.GetComponent<Image>().color.b - 0);*/

    IEnumerator TilesAllCorrect()
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            for (int g = 0; g < tiles[i].transform.childCount; g++)
            {
                coloredLines.Add(tiles[i].transform.GetChild(g).GetComponent<Image>());
            }
        }

        yield return new WaitForSeconds(0.2f);

        for (int i = 0; i < 10; i++)
        {
            FadeColor(1);

            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < 4; i++)
        {
            FadeColor(-1);

            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < 4; i++)
        {
            FadeColor(1);

            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < 10; i++)
        {
            FadeColor(-1);

            yield return new WaitForSeconds(0.01f);
        }

        StartCoroutine(GetComponent<SlideAway>().Slide());
    }
}
