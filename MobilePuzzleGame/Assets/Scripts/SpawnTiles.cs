using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnTiles : MonoBehaviour, ITileList
{
    [SerializeField]
    GameObject tilePrefab;
    [SerializeField]
    GameObject edgePrefab;
    [SerializeField]
    GameObject cornerPrefab;
    [SerializeField]
    GameObject centerPrefab;
    [SerializeField]
    TileStateManager tileStateManager;

    [Space(15)]
    [Range(1, 16)]
    [SerializeField]
    int numberOfTiles;
    [SerializeField]
    List<Vector2> tilePositions = new List<Vector2>();
    [SerializeField]
    List<tileRotation> tileRotations = new List<tileRotation>();
    [SerializeField]
    List<List<tileLines>> tileContents = new List<List<tileLines>>();
    [SerializeField]
    List<ListWrapper> tilelist = new List<ListWrapper>();

    List<GameObject> tiles = new List<GameObject>();
    GameObject tile1;
    GameObject tile2;
    GameObject tile3;
    GameObject tile4;
    GameObject tile5;
    GameObject tile6;
    GameObject tile7;
    GameObject tile8;
    GameObject tile9;
    GameObject tile10;
    GameObject tile11;
    GameObject tile12;
    GameObject tile13;
    GameObject tile14;
    GameObject tile15;
    GameObject tile16;
    enum tileRotation { up, right, down, left }
    List<Vector3> rotations = new List<Vector3>();
    Vector3 tile1Rotation;
    Vector3 tile2Rotation;
    Vector3 tile3Rotation;
    Vector3 tile4Rotation;
    Vector3 tile5Rotation;
    Vector3 tile6Rotation;
    Vector3 tile7Rotation;
    Vector3 tile8Rotation;
    Vector3 tile9Rotation;
    Vector3 tile10Rotation;
    Vector3 tile11Rotation;
    Vector3 tile12Rotation;
    Vector3 tile13Rotation;
    Vector3 tile14Rotation;
    Vector3 tile15Rotation;
    Vector3 tile16Rotation;
    enum tileLines { corner, edge, center }
    List<List<GameObject>> lines = new List<List<GameObject>>();
    
    [Header("Tile 1")]
    public Color za;
    public GameObject zs;
    public Vector3 zd;
    
    void Start()
    {
        tilelist.Add(new ListWrapper { xa = za, xs = zs, xd = zd });

        tiles.Add(tile1);
        tiles.Add(tile2);
        tiles.Add(tile3);
        tiles.Add(tile4);
        tiles.Add(tile5);
        tiles.Add(tile6);
        tiles.Add(tile7);
        tiles.Add(tile8);
        tiles.Add(tile9);
        tiles.Add(tile10);
        tiles.Add(tile11);
        tiles.Add(tile12);
        tiles.Add(tile13);
        tiles.Add(tile14);
        tiles.Add(tile15);
        tiles.Add(tile16);
        
        rotations.Add(tile1Rotation);
        rotations.Add(tile2Rotation);
        rotations.Add(tile3Rotation);
        rotations.Add(tile4Rotation);
        rotations.Add(tile5Rotation);
        rotations.Add(tile6Rotation);
        rotations.Add(tile7Rotation);
        rotations.Add(tile8Rotation);
        rotations.Add(tile9Rotation);
        rotations.Add(tile10Rotation);
        rotations.Add(tile11Rotation);
        rotations.Add(tile12Rotation);
        rotations.Add(tile13Rotation);
        rotations.Add(tile14Rotation);
        rotations.Add(tile15Rotation);
        rotations.Add(tile16Rotation);

        for (int i = 0; i < tileRotations.Count; i++)
        {
            if (tileRotations[i] == tileRotation.up)
            {
                rotations[i] = new Vector3(0, 0, 0);
            }
            else if (tileRotations[i] == tileRotation.right)
            {
                rotations[i] = new Vector3(0, 0, -90);
            }
            else if (tileRotations[i] == tileRotation.down)
            {
                rotations[i] = new Vector3(0, 0, -180);
            }
            else if (tileRotations[i] == tileRotation.left)
            {
                rotations[i] = new Vector3(0, 0, -270);
            }
        }

        for (int i = 0; i < tileContents.Count; i++)
        {
            for (int g = 0; g < tileContents[i].Count; g++)
            {
                if (tileContents[i][g] == tileLines.center)
                {
                    lines[i][g] = centerPrefab;
                }
            }
        }

        for (int i = 0; i < numberOfTiles; i++)
        {
            tiles[i] = Instantiate(tilePrefab, transform) as GameObject;
            tiles[i].transform.localPosition = tilePositions[i];
            tiles[i].transform.localEulerAngles = rotations[i];
            tiles[i].GetComponent<RotateTile>().tilesStateManager = tileStateManager;
            RotateTile rt = tiles[i].GetComponent<RotateTile>();
            tileStateManager.tiles.Add(rt);
        }
    }
}
