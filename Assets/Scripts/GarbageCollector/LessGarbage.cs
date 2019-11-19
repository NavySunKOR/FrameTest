using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessGarbage : MonoBehaviour
{
    private Vector3[] _Vector3 = new Vector3[30];
  

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < _Vector3.Length;i++)
        {
            _Vector3[i].x = 0;
            _Vector3[i].y = 0;
            _Vector3[i].z = 0;
        }
    }
}
