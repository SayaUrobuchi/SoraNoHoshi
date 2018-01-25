using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeIndexValue : IValue<ShotMiko>
{
    public int Level = 0;

    public float Eva(ShotMiko mikosama)
    {
        return mikosama.GetIndex(Level);
    }

    public string Desc()
    {
        return string.Format("樹序列{0}層", Level);
    }
}
