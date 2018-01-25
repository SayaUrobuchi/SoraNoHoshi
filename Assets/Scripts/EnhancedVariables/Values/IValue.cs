using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IValue<T> : ISelfDescriptable
{
    float Eva(T t);
}
