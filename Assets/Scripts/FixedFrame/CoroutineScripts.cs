using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineScripts : MonoBehaviour
{

    private WaitForSeconds _Wait = new WaitForSeconds(0.016f); 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Co_Test());
    }

    IEnumerator Co_Test()
    {
        while(true)
        {
            LogicOne();
            LogicTwo();
            LogicThree();
            yield return _Wait;
        }
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
