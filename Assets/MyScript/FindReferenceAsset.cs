using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FindReferenceAsset : EditorWindow
{
    [MenuItem("Assets/参照を探す",false)]
    public static void FindAssets()
    {
        Debug.Log("Start Find Reference Asset!");
        GetWindow<FindReferenceAsset>();
    }
}
