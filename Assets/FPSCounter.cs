using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text _Text;
    public Text _Average;

    private float _CurrentFrame = 0f;
    private float _CurrentTime = 0f;
    private float _Frame;

    // Update is called once per frame
    void Update()
    {
        _Frame = (1 / Time.unscaledDeltaTime);
        _Text.text = (1 / Time.unscaledDeltaTime).ToString();

        if(Time.time - _CurrentTime > 1f)
        {
            _CurrentTime = Time.time;
            if(_CurrentFrame == 0)
            {
                _CurrentFrame = _Frame;
                Debug.Log(_CurrentFrame);
            }
            else
            {
                _CurrentFrame += _Frame;
                _CurrentFrame = _CurrentFrame / 2f;
                Debug.Log(_CurrentFrame);
            }
        }
    }
}
