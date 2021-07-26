using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAttribute : MonoBehaviour
{
    [ReadOnly]
    public int ReadOnlyPublicInt;

    [SerializeField, ReadOnly]
    private int ReadOnlyPrivateInt;
}
