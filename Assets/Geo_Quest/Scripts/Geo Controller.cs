using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public class Geo : MonoBehaviour
{
    string varOne = "Hello";

    // Start is called before the first frame update
    void Start( )

    {
        string varTwo = "World";
        Debug.Log(varOne + varTwo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
