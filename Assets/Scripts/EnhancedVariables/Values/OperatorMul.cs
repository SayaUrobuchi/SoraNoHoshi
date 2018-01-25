using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorMul<T> : IOperator<T>
{
    public IValue<T> Left;
    public IValue<T> Right;

    public float Eva(T t)
    {
        return Left.Eva(t) * Right.Eva(t);
    }

    public string Desc()
    {
        return OperatorGoddess.OpInori2("({0} * {1})", Left, Right);
    }
}
