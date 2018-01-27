using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedCommonValue : IValue<ShotMiko>
{
    public string ID = "";

    public float Eva(ShotMiko mikosama)
    {
        return mikosama.Owner.GetValue(ID);
    }

    public string Desc()
    {
        return "共通記錄值[" + ID + "]";
    }
}
