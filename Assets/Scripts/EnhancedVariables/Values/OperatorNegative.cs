using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorNegative<T> : IOperator<T>
{
    public IValue<T> Value;

    public float Eva(T t)
    {
        return -Value.Eva(t);
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori1("(-{0})", Value);
    }
}
