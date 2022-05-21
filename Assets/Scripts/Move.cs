using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject eyeLens;
    public GameObject target;
    public GameObject gameObject;
    public Slider slider;

    // Update is called once per frame

    public void Slider_Changed(float newValue)
    {
        Vector3 pos = target.transform.position;
        pos.x = newValue;
        target.transform.position = pos;

        Vector3 size = eyeLens.transform.localScale;
        size.z = newValue*(float)0.005;
        size.y = (20 - newValue/8) * (float)0.02;

        Vector3 _size = eyeLens.transform.localScale;
        _size.z = newValue * (float)0.005;
        _size.y = (20 - newValue / 8) * (float)0.02;

        eyeLens.transform.localScale = size;
    }

}
