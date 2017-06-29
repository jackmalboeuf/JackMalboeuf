using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SpawnTiles))]
public class TileSpawnEditor : Editor
{
    SpawnTiles spawnTiles;
    bool showTile1;

    void OnEnable()
    {
        spawnTiles = (SpawnTiles) target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        showTile1 = EditorGUILayout.Foldout(showTile1, "Tile 1");

        if (showTile1)
        {
            spawnTiles.za = EditorGUILayout.ColorField("za", Color.black);
        }
    }
}
