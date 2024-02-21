using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int BOX_WIDTH = 80;

    private int itemsCount = 4;
    private int guiWidth;
    private Texture tex;

    // Start is called before the first frame update
    void Start()
    {
        guiWidth = BOX_WIDTH * itemsCount;
        tex = AssetDatabase.LoadAssetAtPath<Texture>("Assets/Sprites/milk.png");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(20,20, guiWidth,1000));
        GUILayout.BeginHorizontal();
        for (int i = 0; i < itemsCount; i++)
        {
            // GUILayout.Box(tex);
            GUILayout.Button(tex);
        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
