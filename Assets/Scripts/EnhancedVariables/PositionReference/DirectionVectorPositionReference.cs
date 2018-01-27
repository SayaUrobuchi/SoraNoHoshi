using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVectorPositionReference<T> : IPositionReference<T>
{
    public IValue<T> Angle = new ConstValue<T>(0f);

    public Vector3 Eva(T data)
    {
        float rad = Angle.Eva(data) * Mathf.Deg2Rad;
        return new Vector3(Mathf.Cos(rad), Mathf.Sin(rad));
    }

    public string Desc()
    {
        return SelfDescriptGoddess.Inori1("方向向量{0}度", Angle);
    }
}
