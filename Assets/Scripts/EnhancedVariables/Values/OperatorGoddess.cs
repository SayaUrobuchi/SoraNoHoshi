using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OperatorGoddess
{
    public static string Desc(ISelfDescriptable value)
    {
        return value == null ? "(null)" : value.Desc();
    }

    public static string OpInori1(string pattern, ISelfDescriptable value)
    {
        return string.Format(pattern, Desc(value));
    }

    public static string OpInori2(string pattern, ISelfDescriptable left, ISelfDescriptable right)
    {
        return string.Format(pattern, Desc(left), Desc(right));
    }
}
