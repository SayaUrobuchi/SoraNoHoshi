using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomValue<T> : IValue<T>
{
    public ConstValue<T> Min = new ConstValue<T>(0f);
    public ConstValue<T> Max = new ConstValue<T>(1f);

    public float Eva(T t)
    {
        float min = Min.Eva(t);
        float max = Max.Eva(t);
        return StageMaid.NextRand * (max-min) + min;
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori2("Rand({0}, {1})", Min, Max);
    }
}
