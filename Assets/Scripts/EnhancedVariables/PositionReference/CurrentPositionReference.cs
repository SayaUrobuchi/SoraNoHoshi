using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentPositionReference<T> : IPositionReference<T>
{
    public Vector3 Eva(T data)
    {
        return Vector3.zero;
    }

    public string Desc()
    {
        return "(未實作)";
    }
}
