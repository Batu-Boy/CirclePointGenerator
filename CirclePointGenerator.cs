using System;
using System.Collections.Generic;
using UnityEngine;

public class CirclePointGenerator : MonoBehaviour
{
    [SerializeField] private Transform center;
    [SerializeField] private float radius;
    [SerializeField] private float zPos;

    [SerializeField] private float pointCount;

    [SerializeField] public List<CirclePoint> points;

    [EditorButton()]
    public void GeneratePoints()
    {
        points.Clear();

        for (int i = 0; i < pointCount; i++)
        {
            float progess = (float)i / pointCount;
            float currentRadiant = (float)(progess * Math.PI * 2);
            
            float x = radius * Mathf.Sin(currentRadiant);
            float y = radius * Mathf.Cos(currentRadiant);
            
            Vector3 pos = center.position + new Vector3(x, y, zPos);
            CirclePoint point = new CirclePoint(pos);
            points.Add(point);
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(center.position,radius);
        Gizmos.color = Color.red;
        foreach (var point in points)
        {
            Gizmos.DrawSphere(point.position,.25f);
        }
    }
}
