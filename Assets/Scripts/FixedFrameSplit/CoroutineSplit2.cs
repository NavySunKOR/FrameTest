using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSplit2 : MonoBehaviour
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
            LogicTwo();
            yield return _Wait;
        }
    }

    void LogicTwo()
    {
        for (int i = 0; i < 10000; i++)
        {
            GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }
}
