using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScripts : MonoBehaviour
{
    // Start is called before the first frame update
    private float _CurrentTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if(Time.time - _CurrentTime > 0.016f)
        {
            LogicOne();
            LogicTwo();
            LogicThree();
            _CurrentTime = Time.time;
        }
    }

    void LogicOne()
    {
        for(int i = 0; i < 10000; i++)
        {
            GetComponent<Transform>().position = new Vector3(0,0,0);
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
