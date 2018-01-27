using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedValue : IValue<ShotMiko>, IValue<ShotRule>
{
    public string ID = "";

    public float Eva(ShotMiko mikosama)
    {
        return mikosama.GetValue(ID);
    }

    public float Eva(ShotRule ruler)
    {
        return ruler.GetValue(ID);
    }

    public string Desc()
    {
        return "記錄值[" + ID + "]";
    }
}
