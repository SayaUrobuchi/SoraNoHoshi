using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorDiv<T> : IOperator<T>
{
    public IValue<T> Left;
    public IValue<T> Right;

    public float Eva(T t)
    {
        float rv = Right.Eva(t);
        if (rv == 0f)
        {
            return 0f;
        }
        return Left.Eva(t) / rv;
    }

    public string Desc()
    {
        return OperatorGoddess.OpInori2("({0} / {1})", Left, Right);
    }
}
