using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class ArrayStructure : MonoBehaviour
{
    // Start is called before the first frame update
    private ArrayList _ArrayList;
    void Start()
    {
        _ArrayList = new ArrayList(10);
        for(int i =0; i < 10; i++)
        {
            _ArrayList.Add(i);
        }

        Debug.Log(Marshal.SizeOf<ArrayList>(_ArrayList));
    }

}
