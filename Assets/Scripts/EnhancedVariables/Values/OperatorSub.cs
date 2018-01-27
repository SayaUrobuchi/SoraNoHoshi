using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorSub<T> : IOperator<T>
{
    public IValue<T> Left = new ConstValue<T>(0);
    public IValue<T> Right = new ConstValue<T>(0);

    public float Eva(T t)
    {
        return Left.Eva(t) - Right.Eva(t);
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori2("({0} - {1})", Left, Right);
    }
}
