using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateScripts : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        LogicOne();
        LogicTwo();
        LogicThree();
    }

    void LogicOne()
    {
        for (int i = 0; i < 10000; i++)
        {
            GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }

    void LogicTwo()
    {
        for (int i = 0; i < 10000; i++)
        {
            GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }

    void LogicThree()
    {
        for (int i = 0; i < 10000; i++)
        {
            GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }
}
