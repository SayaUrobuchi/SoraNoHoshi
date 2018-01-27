using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPositionReference<T> : ISelfDescriptable
{
    Vector3 Eva(T data);
}
