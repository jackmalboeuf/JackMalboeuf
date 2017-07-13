using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TileStateManager : MonoBehaviour
{
    [SerializeField]
    SlideAway backgroundPanel;

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

    IEnumerator FadeColor(int increment, int upOrDown)
    {
        float newRValue = 0;
        float newGValue = 0;
        float newBValue = 0;

        for (int i = 0; i < coloredLines.Count; i++)
        {
            if (coloredLines[i].color == new Color32(0, 110, 240, 255))
            {
                print("Asd");
                newRValue = 0.072f;
                newGValue = 0.04f;
                newBValue = 0;
            }
            else if (coloredLines[i].color == new Color32(0, 240, 110, 255))
            {
                newRValue = 0.072f;
                newGValue = 0;
                newBValue = 0.04f;
            }
            else if (coloredLines[i].color == new Color32(240, 0, 110, 255))
            {
                newRValue = 0;
                newGValue = 0.072f;
                newBValue = 0.04f;
            }
        }

        for (int i = 0; i < increment; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                
                
                coloredLines[g].color = new Color(coloredLines[g].color.r + newRValue * upOrDown, coloredLines[g].color.g + newGValue * upOrDown, coloredLines[g].color.b + newBValue * upOrDown);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                newRValue = 0;
                newGValue = 0;
                newBValue = 0;

                if (coloredGoals[h].color == new Color(0, 0.431f, 0.941f))
                {
                    newRValue = 0.072f;
                    newGValue = 0.04f;
                    newBValue = 0;
                }
                else if (coloredGoals[h].color == new Color(0, 0.941f, 0.431f))
                {
                    newRValue = 0.072f;
                    newGValue = 0;
                    newBValue = 0.04f;
                }
                else if (coloredGoals[h].color == new Color(0.941f, 0, 0.431f))
                {
                    newRValue = 0;
                    newGValue = 0.072f;
                    newBValue = 0.04f;
                }

                coloredGoals[h].color = new Color(coloredGoals[h].color.r + newRValue * upOrDown, coloredGoals[h].color.g + newGValue * upOrDown, coloredGoals[h].color.b + newBValue * upOrDown);
            }

            yield return new WaitForSeconds(0.01f);
        }
    }

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

        StartCoroutine(FadeColor(10, 1));
        StartCoroutine(FadeColor(4, -1));
        StartCoroutine(FadeColor(4, 1));
        StartCoroutine(FadeColor(10, -1));

        /*for (int i = 0; i < 10; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                print(coloredLines[g].color);
                coloredLines[g].color = new Color(coloredLines[g].color.r + 0.072f, coloredLines[g].color.g + 0.04f, coloredLines[g].color.b + 0f);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                coloredGoals[h].color = new Color(coloredGoals[h].color.r + 0.072f, coloredGoals[h].color.g + 0.04f, coloredGoals[h].color.b + 0f);
            }

            

            for (int j = 0; j < tiles.Count; j++)
            {
                tiles[j].GetComponent<Image>().color = new Color(tiles[j].GetComponent<Image>().color.r - 0.03f, tiles[j].GetComponent<Image>().color.g - 0, tiles[j].GetComponent<Image>().color.b - 0);
            }

            //backgroundPanel.GetComponent<Image>().color = new Color(backgroundPanel.GetComponent<Image>().color.r - 0.03f, backgroundPanel.GetComponent<Image>().color.g - 0, backgroundPanel.GetComponent<Image>().color.b - 0);

            yield return new WaitForSeconds(0.01f);
        }*/

        /*for (int i = 0; i < 4; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                coloredLines[g].color = new Color(coloredLines[g].color.r - 0.072f, coloredLines[g].color.g - 0.04f, coloredLines[g].color.b + 0f);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                coloredGoals[h].color = new Color(coloredGoals[h].color.r - 0.072f, coloredGoals[h].color.g - 0.04f, coloredGoals[h].color.b + 0f);
            }

            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < 4; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                coloredLines[g].color = new Color(coloredLines[g].color.r + 0.072f, coloredLines[g].color.g + 0.04f, coloredLines[g].color.b + 0f);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                coloredGoals[h].color = new Color(coloredGoals[h].color.r + 0.072f, coloredGoals[h].color.g + 0.04f, coloredGoals[h].color.b + 0f);
            }

            yield return new WaitForSeconds(0.01f);
        }*/

        /*for (int i = 0; i < 4; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                coloredLines[g].color = new Color(coloredLines[g].color.r - 0.072f, coloredLines[g].color.g - 0.04f, coloredLines[g].color.b + 0f);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                coloredGoals[h].color = new Color(coloredGoals[h].color.r - 0.072f, coloredGoals[h].color.g - 0.04f, coloredGoals[h].color.b + 0f);
            }

            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < 4; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                coloredLines[g].color = new Color(coloredLines[g].color.r + 0.072f, coloredLines[g].color.g + 0.04f, coloredLines[g].color.b + 0f);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                coloredGoals[h].color = new Color(coloredGoals[h].color.r + 0.072f, coloredGoals[h].color.g + 0.04f, coloredGoals[h].color.b + 0f);
            }

            yield return new WaitForSeconds(0.01f);
        }*/

        /*for (int i = 0; i < 10; i++)
        {
            for (int g = 0; g < coloredLines.Count; g++)
            {
                coloredLines[g].color = new Color(coloredLines[g].color.r - 0.072f, coloredLines[g].color.g - 0.04f, coloredLines[g].color.b + 0f);
            }

            for (int h = 0; h < coloredGoals.Count; h++)
            {
                coloredGoals[h].color = new Color(coloredGoals[h].color.r - 0.072f, coloredGoals[h].color.g - 0.04f, coloredGoals[h].color.b + 0f);
            }

            yield return new WaitForSeconds(0.01f);
        }*/

        //StartCoroutine(backgroundPanel.Slide());
    }
}
