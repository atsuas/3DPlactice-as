using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 vect;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(vect * Time.deltaTime);
    }
}