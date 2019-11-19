using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSplit2 : MonoBehaviour
{

    private float _CurrentTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Time.time - _CurrentTime > 0.016f)
        {
            LogicTwo();
            _CurrentTime = Time.time;
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
