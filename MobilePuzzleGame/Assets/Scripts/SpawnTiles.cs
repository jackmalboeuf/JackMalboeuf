using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SpawnTiles : MonoBehaviour
{
    [Range(1, 9)]
    [SerializeField]
    int numberOfTiles;
    [Space(15)]
    [Range(2, 6)]
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

    [Header("Goal 5")]
    [SerializeField]
    GameObject goal5Type;
    [SerializeField]
    Color goal5Color;
    [SerializeField]
    Vector2 goal5Position;
    [SerializeField]
    float goal5Rotation;

    [Header("Goal 6")]
    [SerializeField]
    GameObject goal6Type;
    [SerializeField]
    Color goal6Color;
    [SerializeField]
    Vector2 goal6Position;
    [SerializeField]
    float goal6Rotation;

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
    [Space(10)]
    [SerializeField]
    Color tile1CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile1Position;
    [SerializeField]
    float tile1Rotation;
    [Space(10)]
    [SerializeField]
    Transform tile1StartParent;
    [SerializeField]
    Transform tile1CorrectParent;

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
    [Space(10)]
    [SerializeField]
    Color tile2CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile2Position;
    [SerializeField]
    float tile2Rotation;
    [Space(10)]
    [SerializeField]
    Transform tile2StartParent;
    [SerializeField]
    Transform tile2CorrectParent;

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
    [Space(10)]
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
    [Space(10)]
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
    [Space(10)]
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
    [Space(10)]
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
    [Space(10)]
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
    [Space(10)]
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
    [Space(10)]
    [SerializeField]
    Color tile9CenterLineColor;
    [Space(10)]
    [SerializeField]
    Vector2 tile9Position;
    [SerializeField]
    float tile9Rotation;

    GameObject[] goals = new GameObject[6];
    GameObject[] goalTypes = new GameObject[6];
    Color[] goalColors = new Color[6];
    Vector2[] goalPositions = new Vector2[6];
    float[] goalRotations = new float[6];

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
    Transform[] tileStartParents = new Transform[2];
    Transform[] tileCorrectParents = new Transform[2];

    GameObject goal1;
    GameObject goal2;
    GameObject goal3;
    GameObject goal4;
    GameObject goal5;
    GameObject goal6;

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
        goals[4] = goal5;
        goals[5] = goal6;

        goalTypes[0] = goal1Type;
        goalTypes[1] = goal2Type;
        goalTypes[2] = goal3Type;
        goalTypes[3] = goal4Type;
        goalTypes[4] = goal5Type;
        goalTypes[5] = goal6Type;

        goalColors[0] = goal1Color;
        goalColors[1] = goal2Color;
        goalColors[2] = goal3Color;
        goalColors[3] = goal4Color;
        goalColors[4] = goal5Color;
        goalColors[5] = goal6Color;

        goalPositions[0] = goal1Position;
        goalPositions[1] = goal2Position;
        goalPositions[2] = goal3Position;
        goalPositions[3] = goal4Position;
        goalPositions[4] = goal5Position;
        goalPositions[5] = goal6Position;

        goalRotations[0] = goal1Rotation;
        goalRotations[1] = goal2Rotation;
        goalRotations[2] = goal3Rotation;
        goalRotations[3] = goal4Rotation;
        goalRotations[4] = goal5Rotation;
        goalRotations[5] = goal6Rotation;

        tiles[0] = tile1;
        tiles[1] = tile2;
        tiles[2] = tile3;
        tiles[3] = tile4;
        tiles[4] = tile5;
        tiles[5] = tile6;
        tiles[6] = tile7;
        tiles[7] = tile8;
        tiles[8] = tile9;

        line1[0] = tile1Line1;
        line1[1] = tile2Line1;
        line1[2] = tile3Line1;
        line1[3] = tile4Line1;
        line1[4] = tile5Line1;
        line1[5] = tile6Line1;
        line1[6] = tile7Line1;
        line1[7] = tile8Line1;
        line1[8] = tile9Line1;

        line2[0] = tile1Line2;
        line2[1] = tile2Line2;
        line2[2] = tile3Line2;
        line2[3] = tile4Line2;
        line2[4] = tile5Line2;
        line2[5] = tile6Line2;
        line2[6] = tile7Line2;
        line2[7] = tile8Line2;
        line2[8] = tile9Line2;

        line3[0] = tile1Line3;
        line3[1] = tile2Line3;
        line3[2] = tile3Line3;
        line3[3] = tile4Line3;
        line3[4] = tile5Line3;
        line3[5] = tile6Line3;
        line3[6] = tile7Line3;
        line3[7] = tile8Line3;
        line3[8] = tile9Line3;

        line4[0] = tile1Line4;
        line4[1] = tile2Line4;
        line4[2] = tile3Line4;
        line4[3] = tile4Line4;
        line4[4] = tile5Line4;
        line4[5] = tile6Line4;
        line4[6] = tile7Line4;
        line4[7] = tile8Line4;
        line4[8] = tile9Line4;

        line1Type[0] = tile1Line1Type;
        line1Type[1] = tile2Line1Type;
        line1Type[2] = tile3Line1Type;
        line1Type[3] = tile4Line1Type;
        line1Type[4] = tile5Line1Type;
        line1Type[5] = tile6Line1Type;
        line1Type[6] = tile7Line1Type;
        line1Type[7] = tile8Line1Type;
        line1Type[8] = tile9Line1Type;

        line1Color[0] = tile1Line1Color;
        line1Color[1] = tile2Line1Color;
        line1Color[2] = tile3Line1Color;
        line1Color[3] = tile4Line1Color;
        line1Color[4] = tile5Line1Color;
        line1Color[5] = tile6Line1Color;
        line1Color[6] = tile7Line1Color;
        line1Color[7] = tile8Line1Color;
        line1Color[8] = tile9Line1Color;

        line1Rotation[0] = tile1Line1Rotation;
        line1Rotation[1] = tile2Line1Rotation;
        line1Rotation[2] = tile3Line1Rotation;
        line1Rotation[3] = tile4Line1Rotation;
        line1Rotation[4] = tile5Line1Rotation;
        line1Rotation[5] = tile6Line1Rotation;
        line1Rotation[6] = tile7Line1Rotation;
        line1Rotation[7] = tile8Line1Rotation;
        line1Rotation[8] = tile9Line1Rotation;

        line2Type[0] = tile1Line2Type;
        line2Type[1] = tile2Line2Type;
        line2Type[2] = tile3Line2Type;
        line2Type[3] = tile4Line2Type;
        line2Type[4] = tile5Line2Type;
        line2Type[5] = tile6Line2Type;
        line2Type[6] = tile7Line2Type;
        line2Type[7] = tile8Line2Type;
        line2Type[8] = tile9Line2Type;

        line2Color[0] = tile1Line2Color;
        line2Color[1] = tile2Line2Color;
        line2Color[2] = tile3Line2Color;
        line2Color[3] = tile4Line2Color;
        line2Color[4] = tile5Line2Color;
        line2Color[5] = tile6Line2Color;
        line2Color[6] = tile7Line2Color;
        line2Color[7] = tile8Line2Color;
        line2Color[8] = tile9Line2Color;

        line2Rotation[0] = tile1Line2Rotation;
        line2Rotation[1] = tile2Line2Rotation;
        line2Rotation[2] = tile3Line2Rotation;
        line2Rotation[3] = tile4Line2Rotation;
        line2Rotation[4] = tile5Line2Rotation;
        line2Rotation[5] = tile6Line2Rotation;
        line2Rotation[6] = tile7Line2Rotation;
        line2Rotation[7] = tile8Line2Rotation;
        line2Rotation[8] = tile9Line2Rotation;

        line3Type[0] = tile1Line3Type;
        line3Type[1] = tile2Line3Type;
        line3Type[2] = tile3Line3Type;
        line3Type[3] = tile4Line3Type;
        line3Type[4] = tile5Line3Type;
        line3Type[5] = tile6Line3Type;
        line3Type[6] = tile7Line3Type;
        line3Type[7] = tile8Line3Type;
        line3Type[8] = tile9Line3Type;

        line3Color[0] = tile1Line3Color;
        line3Color[1] = tile2Line3Color;
        line3Color[2] = tile3Line3Color;
        line3Color[3] = tile4Line3Color;
        line3Color[4] = tile5Line3Color;
        line3Color[5] = tile6Line3Color;
        line3Color[6] = tile7Line3Color;
        line3Color[7] = tile8Line3Color;
        line3Color[8] = tile9Line3Color;

        line3Rotation[0] = tile1Line3Rotation;
        line3Rotation[1] = tile2Line3Rotation;
        line3Rotation[2] = tile3Line3Rotation;
        line3Rotation[3] = tile4Line3Rotation;
        line3Rotation[4] = tile5Line3Rotation;
        line3Rotation[5] = tile6Line3Rotation;
        line3Rotation[6] = tile7Line3Rotation;
        line3Rotation[7] = tile8Line3Rotation;
        line3Rotation[8] = tile9Line3Rotation;

        line4Type[0] = tile1Line4Type;
        line4Type[1] = tile2Line4Type;
        line4Type[2] = tile3Line4Type;
        line4Type[3] = tile4Line4Type;
        line4Type[4] = tile5Line4Type;
        line4Type[5] = tile6Line4Type;
        line4Type[6] = tile7Line4Type;
        line4Type[7] = tile8Line4Type;
        line4Type[8] = tile9Line4Type;

        line4Color[0] = tile1Line4Color;
        line4Color[1] = tile2Line4Color;
        line4Color[2] = tile3Line4Color;
        line4Color[3] = tile4Line4Color;
        line4Color[4] = tile5Line4Color;
        line4Color[5] = tile6Line4Color;
        line4Color[6] = tile7Line4Color;
        line4Color[7] = tile8Line4Color;
        line4Color[8] = tile9Line4Color;

        line4Rotation[0] = tile1Line4Rotation;
        line4Rotation[1] = tile2Line4Rotation;
        line4Rotation[2] = tile3Line4Rotation;
        line4Rotation[3] = tile4Line4Rotation;
        line4Rotation[4] = tile5Line4Rotation;
        line4Rotation[5] = tile6Line4Rotation;
        line4Rotation[6] = tile7Line4Rotation;
        line4Rotation[7] = tile8Line4Rotation;
        line4Rotation[8] = tile9Line4Rotation;

        centerLineColor[0] = tile1CenterLineColor;
        centerLineColor[1] = tile2CenterLineColor;
        centerLineColor[2] = tile3CenterLineColor;
        centerLineColor[3] = tile4CenterLineColor;
        centerLineColor[4] = tile5CenterLineColor;
        centerLineColor[5] = tile6CenterLineColor;
        centerLineColor[6] = tile7CenterLineColor;
        centerLineColor[7] = tile8CenterLineColor;
        centerLineColor[8] = tile9CenterLineColor;

        tilePositions[0] = tile1Position;
        tilePositions[1] = tile2Position;
        tilePositions[2] = tile3Position;
        tilePositions[3] = tile4Position;
        tilePositions[4] = tile5Position;
        tilePositions[5] = tile6Position;
        tilePositions[6] = tile7Position;
        tilePositions[7] = tile8Position;
        tilePositions[8] = tile9Position;

        tileRotations[0] = tile1Rotation;
        tileRotations[1] = tile2Rotation;
        tileRotations[2] = tile3Rotation;
        tileRotations[3] = tile4Rotation;
        tileRotations[4] = tile5Rotation;
        tileRotations[5] = tile6Rotation;
        tileRotations[6] = tile7Rotation;
        tileRotations[7] = tile8Rotation;
        tileRotations[8] = tile9Rotation;

        tileStartParents[0] = tile1StartParent;
        tileStartParents[1] = tile2StartParent;

        tileCorrectParents[0] = tile1CorrectParent;
        tileCorrectParents[1] = tile2CorrectParent;

        for (int i = 0; i < numberOfGoals; i++)
        {
            goals[i] = Instantiate(goalTypes[i], transform) as GameObject;
            goals[i].transform.localPosition = goalPositions[i];
            goals[i].GetComponent<Image>().color = goalColors[i];
            goals[i].transform.localEulerAngles = new Vector3(0, 0, goalRotations[i]);
            goals[i].transform.localScale = new Vector3(1, 1, 1);
            goals[i].transform.SetAsFirstSibling();
            GetComponent<TileStateManager>().coloredGoals.Add(goals[i].GetComponent<Image>());
        }

        for (int i = 0; i < numberOfTiles; i++)
        {
            tiles[i] = Instantiate(tilePrefab, transform) as GameObject;
            tiles[i].transform.localPosition = tilePositions[i];
            tiles[i].transform.localEulerAngles = new Vector3(0, 0, tileRotations[i]);
            tiles[i].transform.localScale = new Vector3(1, 1, 1);

            if (tileStartParents[i] != null && tileCorrectParents[i] != null)
            {
                tiles[i].AddComponent<CanvasGroup>();
                tiles[i].AddComponent<DragObject>();
                tiles[i].transform.SetParent(tileStartParents[i]);
                tiles[i].transform.localPosition = new Vector2(0, 0);
                tiles[i].GetComponent<DragObject>().correctParent = tileCorrectParents[i];
            }

            tiles[i].GetComponent<RotateTile>().tilesStateManager = GetComponent<TileStateManager>();
            RotateTile rt = tiles[i].GetComponent<RotateTile>();
            GetComponent<TileStateManager>().tiles.Add(rt);

            if (line1Type[i] != null)
            {
                line1[i] = Instantiate(line1Type[i], tiles[i].transform) as GameObject;
                line1[i].transform.localPosition = new Vector2(0, 0);
                line1[i].GetComponent<Image>().color = line1Color[i];
                line1[i].transform.localEulerAngles = new Vector3(0, 0, line1Rotation[i]);
                line1[i].transform.localScale = new Vector3(1, 1, 1);
            }

            if (line2Type[i] != null)
            {
                line2[i] = Instantiate(line2Type[i], tiles[i].transform) as GameObject;
                line2[i].transform.localPosition = new Vector2(0, 0);
                line2[i].GetComponent<Image>().color = line2Color[i];
                line2[i].transform.localEulerAngles = new Vector3(0, 0, line2Rotation[i]);
                line2[i].transform.localScale = new Vector3(1, 1, 1);
            }

            if (line3Type[i] != null)
            {
                line3[i] = Instantiate(line3Type[i], tiles[i].transform) as GameObject;
                line3[i].transform.localPosition = new Vector2(0, 0);
                line3[i].GetComponent<Image>().color = line3Color[i];
                line3[i].transform.localEulerAngles = new Vector3(0, 0, line3Rotation[i]);
                line3[i].transform.localScale = new Vector3(1, 1, 1);
            }

            if (line4Type[i] != null)
            {
                line4[i] = Instantiate(line4Type[i], tiles[i].transform) as GameObject;
                line4[i].transform.localPosition = new Vector2(0, 0);
                line4[i].GetComponent<Image>().color = line4Color[i];
                line4[i].transform.localEulerAngles = new Vector3(0, 0, line4Rotation[i]);
                line4[i].transform.localScale = new Vector3(1, 1, 1);
            }

            centerLine[i] = Instantiate(centerPrefab, tiles[i].transform) as GameObject;
            centerLine[i].transform.localPosition = new Vector2(0, 0);
            centerLine[i].GetComponent<Image>().color = centerLineColor[i];
            centerLine[i].transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
