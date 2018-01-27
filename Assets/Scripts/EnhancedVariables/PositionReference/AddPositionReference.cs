using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPositionReference<T> : IPositionReference<T>
{
    public IPositionReference<T> Left = new CustomVectorPositionReference<T>();
    public IPositionReference<T> Right = new CustomVectorPositionReference<T>();

    public Vector3 Eva(T data)
    {
        return Left.Eva(data) + Right.Eva(data);
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori2("({0} + {1})", Left, Right);
    }
}
