using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private float dist;
    private float counter; 
 
    public Transform origin;
    public Transform destination;

    private Transform[] points;
    public float lineDrawSpeed = 8f;
    // Start is called before the first frame update
    private void Awake()
    {
        lineRenderer = GetComponent <LineRenderer>();
        //lineRenderer.SetPosition(0, origin.position);

        //dist = Vector3.Distance(origin.position, destination.position);
    }

    public void SetUpLine(Transform[] points)
    {
        lineRenderer.positionCount = points.Length;
        this.points = points;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0; i < points.Length; ++i)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
        /*if(counter < dist)
        {
            counter += .1f / lineDrawSpeed;

            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = origin.position;
            Vector3 pointB = destination.position;


            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRenderer.SetPosition(1, pointAlongLine);
        }*/
    }
}
