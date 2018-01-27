using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCommonSavedPositionReference : IPositionReference<ShotMiko>
{
    public string ID = "";

    public Vector3 Eva(ShotMiko mikosama)
    {
        return mikosama.Owner.GetPosition(ID);
    }

    public string Desc()
    {
        return "共用記錄座標[" + ID + "]";
    }
}
