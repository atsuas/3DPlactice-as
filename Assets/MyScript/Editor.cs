using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Editor : MonoBehaviour
{
    //SerializeField
    public int public_int;

    [SerializeField]
    private int private_int;

    [SerializeField]
    protected int protected_int;

    //インスペクタ上では「m_」は消える
    [SerializeField]
    private int m_int;

    [SerializeField]
    private int[] intArray;

    [SerializeField]
    private List<GameObject> GameObjectList;


    //Range
    [Range(1, 10)]
    public int RangeInt;

    [SerializeField, Range(-1f, 1f)]
    private float rangeFloat;


    //Tooltip
    [SerializeField, Tooltip("整数の値")]
    private int intValue;


    //Header
    [SerializeField, Header("浮動小数点数型です")]
    private float floatValue;


    //Space
    //密集している時などにスペースを空けると見やすい
    [SerializeField]
    private int intValue1;

    [SerializeField, Space(10)]
    private int intValue2;

    [SerializeField]
    private float floatValue1;

    [SerializeField, Space(20)]
    private float floatValue2;

    [SerializeField, Multiline(3)]
    private string stringValue;


    //TextArea
    //テキストフィールド、最小値と最大値を設定できる
    [SerializeField, TextArea(2, 4)]
    private string stringValue1;


    //HideInIndpector
    //SerializeFieldで値は保持しておきたいが、インスペクタから表示を隠したいとき
    [HideInInspector]
    public int intValueH;

    //HideInInspecterを使うとHeaderも見えなくなる
    [SerializeField, HideInInspector, Header("aaa")]
    private float floatValueH;
    
}
