using System;
using UnityEngine;

[Serializable]
public class CirclePoint
{
    public Vector3 position;
    public CirclePoint(Vector3 position)
    {
        this.position = position;
    }
}
