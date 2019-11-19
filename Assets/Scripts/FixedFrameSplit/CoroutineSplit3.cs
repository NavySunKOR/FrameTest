using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSplit3 : MonoBehaviour
{

    private WaitForSeconds _Wait = new WaitForSeconds(0.016f);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Co_Test());
    }

    IEnumerator Co_Test()
    {
        while (true)
        {
            LogicThree();
            yield return _Wait;
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
