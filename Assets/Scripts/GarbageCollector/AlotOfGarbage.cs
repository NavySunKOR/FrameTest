using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlotOfGarbage : MonoBehaviour
{
    private Vector3[] _Vector3;
    // Update is called once per frame
    void Update()
    {
        _Vector3 = new Vector3[30];
    }
}
