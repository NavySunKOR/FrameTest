using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateSplit3 : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        LogicThree();
    }
    void LogicThree()
    {
        for (int i = 0; i < 10000; i++)
        {
            GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }
}
