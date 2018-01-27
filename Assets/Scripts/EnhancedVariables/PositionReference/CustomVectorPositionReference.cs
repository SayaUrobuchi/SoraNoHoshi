using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomVectorPositionReference<T> : IPositionReference<T>
{
    [SelfDesc]
    public IValue<T> X = new ConstValue<T>(0f);
    [SelfDesc]
    public IValue<T> Y = new ConstValue<T>(0f);

    public Vector3 Eva(T data)
    {
        return new Vector3(X.Eva(data), Y.Eva(data));
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori2("[{0}, {1}]", X, Y);
    }
}
