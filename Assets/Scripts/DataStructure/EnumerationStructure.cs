using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class EnumerationStructure : MonoBehaviour
{
    // Start is called before the first frame update
    private Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            keyValuePairs.Add(i, i);
        }

        Debug.Log(Marshal.SizeOf<Dictionary<int, int>>(keyValuePairs));
    }
}
