using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class SelfDescAttribute : Attribute
{
    public SelfDescAttribute(int lengthThreshold = 0)
    {
    }
}