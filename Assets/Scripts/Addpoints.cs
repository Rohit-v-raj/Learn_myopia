using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addpoints : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform[] points;
    [SerializeField] private DrawLine line;
    void Start()
    {
        line.SetUpLine(points);
    }

}
