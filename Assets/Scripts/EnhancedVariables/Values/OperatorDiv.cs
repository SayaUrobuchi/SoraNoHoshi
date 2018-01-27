using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorDiv<T> : IOperator<T>
{
    public IValue<T> Left = new ConstValue<T>(0);
    public IValue<T> Right = new ConstValue<T>(0);

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
        return SelfDescriptGoddess.Inori2("({0} / {1})", Left, Right);
    }
}
