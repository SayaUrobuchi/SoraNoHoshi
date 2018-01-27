using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulPositionReference<T> : IPositionReference<T>
{
    public IPositionReference<T> Left = new CustomVectorPositionReference<T>();
    public IValue<T> Right = new ConstValue<T>(1f);

    public Vector3 Eva(T data)
    {
        return Left.Eva(data) * Right.Eva(data);
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori2("({0} * {1})", Left, Right);
    }
}
