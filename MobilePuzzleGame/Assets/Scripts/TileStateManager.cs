using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileStateManager : MonoBehaviour
{
    [SerializeField]
    SlideAway backgroundPanel;

    [HideInInspector]
    public List<RotateTile> tiles = new List<RotateTile>();

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
            StartCoroutine(backgroundPanel.Slide());
        }
    }
}
