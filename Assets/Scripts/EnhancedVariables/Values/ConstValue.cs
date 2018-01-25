using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstValue<T> : IValue<T>
{
    public float Value = 0f;

    public ConstValue()
    {
    }

    public ConstValue(float val)
    {
        Value = val;
    }

    public float Eva(T t)
    {
        return Value;
    }

    public string Desc()
    {
        return Value.ToString();
    }
}
