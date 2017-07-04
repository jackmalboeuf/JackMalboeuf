using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SpawnTiles : MonoBehaviour, ITileList
{
    [SerializeField]
    TileStateManager tileStateManager;
    [Space(15)]
    [Range(1, 9)]
    [SerializeField]
    int numberOfTiles;
    [Space(15)]
    [Range(2, 4)]
    [SerializeField]
    int numberOfGoals;

    [Header("Goal 1")]
    [SerializeField]
    GameObject goal1Type;
    [SerializeField]
    Color goal1Color;
    [SerializeField]
    Vector2 goal1Position;
    [SerializeField]
    float goal1Rotation;

    [Header("Goal 2")]
    [SerializeField]
    GameObject goal2Type;
    [SerializeField]
    Color goal2Color;
    [SerializeField]
    Vector2 goal2Position;
    [SerializeField]
    float goal2Rotation;

    [Header("Goal 3")]
    [SerializeField]
    GameObject goal3Type;
    [SerializeField]
    Color goal3Color;
    [SerializeField]
    Vector2 goal3Position;
    [SerializeField]
    float goal3Rotation;

    [Header("Goal 4")]
    [SerializeField]
    GameObject goal4Type;
    [SerializeField]
    Color goal4Color;
    [SerializeField]
    Vector2 goal4Position;
    [SerializeField]
    float goal4Rotation;

    [Header("Tile 1")]
    [SerializeField]
    GameObject tile1Line1Type;
    [SerializeField]
    Color tile1Line1Color;
    [SerializeField]
    float tile1Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile1Line2Type;
    [SerializeField]
    Color tile1Line2Color;
    [SerializeField]
    float tile1Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile1Line3Type;
    [SerializeField]
    Color tile1Line3Color;
    [SerializeField]
    float tile1Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile1Line4Type;
    [SerializeField]
    Color tile1Line4Color;
    [SerializeField]
    float tile1Line4Rotation;
    [SerializeField]
    Color tile1CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile1Position;
    [SerializeField]
    float tile1Rotation;

    [Header("Tile 2")]
    [SerializeField]
    GameObject tile2Line1Type;
    [SerializeField]
    Color tile2Line1Color;
    [SerializeField]
    float tile2Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile2Line2Type;
    [SerializeField]
    Color tile2Line2Color;
    [SerializeField]
    float tile2Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile2Line3Type;
    [SerializeField]
    Color tile2Line3Color;
    [SerializeField]
    float tile2Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile2Line4Type;
    [SerializeField]
    Color tile2Line4Color;
    [SerializeField]
    float tile2Line4Rotation;
    [SerializeField]
    Color tile2CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile2Position;
    [SerializeField]
    float tile2Rotation;

    [Header("Tile 3")]
    [SerializeField]
    GameObject tile3Line1Type;
    [SerializeField]
    Color tile3Line1Color;
    [SerializeField]
    float tile3Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile3Line2Type;
    [SerializeField]
    Color tile3Line2Color;
    [SerializeField]
    float tile3Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile3Line3Type;
    [SerializeField]
    Color tile3Line3Color;
    [SerializeField]
    float tile3Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile3Line4Type;
    [SerializeField]
    Color tile3Line4Color;
    [SerializeField]
    float tile3Line4Rotation;
    [SerializeField]
    Color tile3CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile3Position;
    [SerializeField]
    float tile3Rotation;

    [Header("Tile 4")]
    [SerializeField]
    GameObject tile4Line1Type;
    [SerializeField]
    Color tile4Line1Color;
    [SerializeField]
    float tile4Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile4Line2Type;
    [SerializeField]
    Color tile4Line2Color;
    [SerializeField]
    float tile4Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile4Line3Type;
    [SerializeField]
    Color tile4Line3Color;
    [SerializeField]
    float tile4Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile4Line4Type;
    [SerializeField]
    Color tile4Line4Color;
    [SerializeField]
    float tile4Line4Rotation;
    [SerializeField]
    Color tile4CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile4Position;
    [SerializeField]
    float tile4Rotation;

    [Header("Tile 5")]
    [SerializeField]
    GameObject tile5Line1Type;
    [SerializeField]
    Color tile5Line1Color;
    [SerializeField]
    float tile5Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile5Line2Type;
    [SerializeField]
    Color tile5Line2Color;
    [SerializeField]
    float tile5Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile5Line3Type;
    [SerializeField]
    Color tile5Line3Color;
    [SerializeField]
    float tile5Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile5Line4Type;
    [SerializeField]
    Color tile5Line4Color;
    [SerializeField]
    float tile5Line4Rotation;
    [SerializeField]
    Color tile5CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile5Position;
    [SerializeField]
    float tile5Rotation;

    [Header("Tile 6")]
    [SerializeField]
    GameObject tile6Line1Type;
    [SerializeField]
    Color tile6Line1Color;
    [SerializeField]
    float tile6Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile6Line2Type;
    [SerializeField]
    Color tile6Line2Color;
    [SerializeField]
    float tile6Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile6Line3Type;
    [SerializeField]
    Color tile6Line3Color;
    [SerializeField]
    float tile6Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile6Line4Type;
    [SerializeField]
    Color tile6Line4Color;
    [SerializeField]
    float tile6Line4Rotation;
    [SerializeField]
    Color tile6CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile6Position;
    [SerializeField]
    float tile6Rotation;

    [Header("Tile 7")]
    [SerializeField]
    GameObject tile7Line1Type;
    [SerializeField]
    Color tile7Line1Color;
    [SerializeField]
    float tile7Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile7Line2Type;
    [SerializeField]
    Color tile7Line2Color;
    [SerializeField]
    float tile7Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile7Line3Type;
    [SerializeField]
    Color tile7Line3Color;
    [SerializeField]
    float tile7Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile7Line4Type;
    [SerializeField]
    Color tile7Line4Color;
    [SerializeField]
    float tile7Line4Rotation;
    [SerializeField]
    Color tile7CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile7Position;
    [SerializeField]
    float tile7Rotation;

    [Header("Tile 8")]
    [SerializeField]
    GameObject tile8Line1Type;
    [SerializeField]
    Color tile8Line1Color;
    [SerializeField]
    float tile8Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile8Line2Type;
    [SerializeField]
    Color tile8Line2Color;
    [SerializeField]
    float tile8Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile8Line3Type;
    [SerializeField]
    Color tile8Line3Color;
    [SerializeField]
    float tile8Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile8Line4Type;
    [SerializeField]
    Color tile8Line4Color;
    [SerializeField]
    float tile8Line4Rotation;
    [SerializeField]
    Color tile8CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile8Position;
    [SerializeField]
    float tile8Rotation;

    [Header("Tile 9")]
    [SerializeField]
    GameObject tile9Line1Type;
    [SerializeField]
    Color tile9Line1Color;
    [SerializeField]
    float tile9Line1Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile9Line2Type;
    [SerializeField]
    Color tile9Line2Color;
    [SerializeField]
    float tile9Line2Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile9Line3Type;
    [SerializeField]
    Color tile9Line3Color;
    [SerializeField]
    float tile9Line3Rotation;
    [Space(10)]
    [SerializeField]
    GameObject tile9Line4Type;
    [SerializeField]
    Color tile9Line4Color;
    [SerializeField]
    float tile9Line4Rotation;
    [SerializeField]
    Color tile9CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile9Position;
    [SerializeField]
    float tile9Rotation;

    GameObject[] goals = new GameObject[4];
    GameObject[] goalTypes = new GameObject[4];
    Color[] goalColors = new Color[4];
    Vector2[] goalPositions = new Vector2[4];
    float[] goalRotations = new float[4];

    GameObject[] tiles = new GameObject[9];
    GameObject[] line1 = new GameObject[9];
    GameObject[] line2 = new GameObject[9];
    GameObject[] line3 = new GameObject[9];
    GameObject[] line4 = new GameObject[9];
    GameObject[] centerLine = new GameObject[9];
    GameObject[] line1Type = new GameObject[9];
    Color[] line1Color = new Color[9];
    float[] line1Rotation = new float[9];
    GameObject[] line2Type = new GameObject[9];
    Color[] line2Color = new Color[9];
    float[] line2Rotation = new float[9];
    GameObject[] line3Type = new GameObject[9];
    Color[] line3Color = new Color[9];
    float[] line3Rotation = new float[9];
    GameObject[] line4Type = new GameObject[9];
    Color[] line4Color = new Color[9];
    float[] line4Rotation = new float[9];
    Color[] centerLineColor = new Color[9];
    Vector2[] tilePositions = new Vector2[9];
    float[] tileRotations = new float[9];

    GameObject goal1;
    GameObject goal2;
    GameObject goal3;
    GameObject goal4;

    GameObject tilePrefab;
    GameObject edgePrefab;
    GameObject cornerPrefab;
    GameObject centerPrefab;
    GameObject tile1;
    GameObject tile2;
    GameObject tile3;
    GameObject tile4;
    GameObject tile5;
    GameObject tile6;
    GameObject tile7;
    GameObject tile8;
    GameObject tile9;
    GameObject tile1Line1;
    GameObject tile2Line1;
    GameObject tile3Line1;
    GameObject tile4Line1;
    GameObject tile5Line1;
    GameObject tile6Line1;
    GameObject tile7Line1;
    GameObject tile8Line1;
    GameObject tile9Line1;
    GameObject tile1Line2;
    GameObject tile2Line2;
    GameObject tile3Line2;
    GameObject tile4Line2;
    GameObject tile5Line2;
    GameObject tile6Line2;
    GameObject tile7Line2;
    GameObject tile8Line2;
    GameObject tile9Line2;
    GameObject tile1Line3;
    GameObject tile2Line3;
    GameObject tile3Line3;
    GameObject tile4Line3;
    GameObject tile5Line3;
    GameObject tile6Line3;
    GameObject tile7Line3;
    GameObject tile8Line3;
    GameObject tile9Line3;
    GameObject tile1Line4;
    GameObject tile2Line4;
    GameObject tile3Line4;
    GameObject tile4Line4;
    GameObject tile5Line4;
    GameObject tile6Line4;
    GameObject tile7Line4;
    GameObject tile8Line4;
    GameObject tile9Line4;

    void Start()
    {
        tilePrefab = Resources.Load("Tile") as GameObject;
        edgePrefab = Resources.Load("EdgeLine") as GameObject;
        cornerPrefab = Resources.Load("CornerLine") as GameObject;
        centerPrefab = Resources.Load("CenterLine") as GameObject;

        goals[0] = goal1;
        goals[1] = goal2;
        goals[2] = goal3;
        goals[3] = goal4;

        goalTypes[0] = goal1Type;
        goalTypes[1] = goal2Type;
        goalTypes[2] = goal3Type;
        goalTypes[3] = goal4Type;

        goalColors[0] = goal1Color;
        goalColors[1] = goal2Color;
        goalColors[2] = goal3Color;
        goalColors[3] = goal4Color;

        goalPositions[0] = goal1Position;
        goalPositions[1] = goal2Position;
        goalPositions[2] = goal3Position;
        goalPositions[3] = goal4Position;

        goalRotations[0] = goal1Rotation;
        goalRotations[1] = goal2Rotation;
        goalRotations[2] = goal3Rotation;
        goalRotations[3] = goal4Rotation;

        tiles[0] = tile1;
        tiles[1] = tile2;
        tiles[2] = tile3;

        line1[0] = tile1Line1;
        line1[1] = tile2Line1;
        line1[2] = tile3Line1;

        line2[0] = tile1Line2;
        line2[1] = tile2Line2;
        line2[2] = tile3Line2;

        line3[0] = tile1Line3;
        line3[1] = tile2Line3;
        line3[2] = tile3Line3;

        line4[0] = tile1Line4;
        line4[1] = tile2Line4;
        line4[2] = tile3Line4;

        line1Type[0] = tile1Line1Type;
        line1Type[1] = tile2Line1Type;
        line1Type[2] = tile3Line1Type;

        line1Color[0] = tile1Line1Color;
        line1Color[1] = tile2Line1Color;
        line1Color[2] = tile3Line1Color;

        line1Rotation[0] = tile1Line1Rotation;
        line1Rotation[1] = tile2Line1Rotation;
        line1Rotation[2] = tile3Line1Rotation;

        line2Type[0] = tile1Line2Type;
        line2Type[1] = tile2Line2Type;
        line2Type[2] = tile3Line2Type;
    
        line2Color[0] = tile1Line2Color;
        line2Color[1] = tile2Line2Color;
        line2Color[2] = tile3Line2Color;
        
        line2Rotation[0] = tile1Line2Rotation;
        line2Rotation[1] = tile2Line2Rotation;
        line2Rotation[2] = tile3Line2Rotation;

        line3Type[0] = tile1Line3Type;
        line3Type[1] = tile2Line3Type;
        line3Type[2] = tile3Line3Type;

        line3Color[0] = tile1Line3Color;
        line3Color[1] = tile2Line3Color;
        line3Color[2] = tile3Line3Color;

        line3Rotation[0] = tile1Line3Rotation;
        line3Rotation[1] = tile2Line3Rotation;
        line3Rotation[2] = tile3Line3Rotation;

        line4Type[0] = tile1Line4Type;
        line4Type[1] = tile2Line4Type;
        line4Type[2] = tile3Line4Type;

        line4Color[0] = tile1Line4Color;
        line4Color[1] = tile2Line4Color;
        line4Color[2] = tile3Line4Color;

        line4Rotation[0] = tile1Line4Rotation;
        line4Rotation[1] = tile2Line4Rotation;
        line4Rotation[2] = tile3Line4Rotation;

        centerLineColor[0] = tile1CenterLineColor;
        centerLineColor[1] = tile2CenterLineColor;
        centerLineColor[2] = tile3CenterLineColor;

        tilePositions[0] = tile1Position;
        tilePositions[1] = tile2Position;
        tilePositions[2] = tile3Position;

        tileRotations[0] = tile1Rotation;
        tileRotations[1] = tile2Rotation;
        tileRotations[2] = tile3Rotation;

        for (int i = 0; i < numberOfGoals; i++)
        {
            goals[i] = Instantiate(goalTypes[i], transform) as GameObject;
            goals[i].transform.localPosition = goalPositions[i];
            goals[i].GetComponent<Image>().color = goalColors[i];
            goals[i].transform.localEulerAngles = new Vector3(0, 0, goalRotations[i]);
        }

        for (int i = 0; i < numberOfTiles; i++)
        {
            tiles[i] = Instantiate(tilePrefab, transform) as GameObject;
            tiles[i].transform.localPosition = tilePositions[i];
            tiles[i].transform.localEulerAngles = new Vector3(0, 0, tileRotations[i]);
            tiles[i].GetComponent<RotateTile>().tilesStateManager = tileStateManager;
            RotateTile rt = tiles[i].GetComponent<RotateTile>();
            tileStateManager.tiles.Add(rt);

            if (line1Type[i] != null)
            {
                line1[i] = Instantiate(line1Type[i], tiles[i].transform) as GameObject;
                line1[i].transform.localPosition = new Vector2(0, 0);
                line1[i].GetComponent<Image>().color = line1Color[i];
                line1[i].transform.localEulerAngles = new Vector3(0, 0, line1Rotation[i]);
            }

            if (line2Type[i] != null)
            {
                line2[i] = Instantiate(line2Type[i], tiles[i].transform) as GameObject;
                line2[i].transform.localPosition = new Vector2(0, 0);
                line2[i].GetComponent<Image>().color = line2Color[i];
                line2[i].transform.localEulerAngles = new Vector3(0, 0, line2Rotation[i]);
            }

            if (line3Type[i] != null)
            {
                line3[i] = Instantiate(line3Type[i], tiles[i].transform) as GameObject;
                line3[i].transform.localPosition = new Vector2(0, 0);
                line3[i].GetComponent<Image>().color = line3Color[i];
                line3[i].transform.localEulerAngles = new Vector3(0, 0, line3Rotation[i]);
            }

            if (line4Type[i] != null)
            {
                line4[i] = Instantiate(line4Type[i], tiles[i].transform) as GameObject;
                line4[i].transform.localPosition = new Vector2(0, 0);
                line4[i].GetComponent<Image>().color = line4Color[i];
                line4[i].transform.localEulerAngles = new Vector3(0, 0, line4Rotation[i]);
            }

            centerLine[i] = Instantiate(centerPrefab, tiles[i].transform) as GameObject;
            centerLine[i].transform.localPosition = new Vector2(0, 0);
            centerLine[i].GetComponent<Image>().color = centerLineColor[i];
        }
    }
}
