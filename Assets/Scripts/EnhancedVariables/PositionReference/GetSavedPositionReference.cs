using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSavedPositionReference : IPositionReference<ShotMiko>, IPositionReference<ShotRule>
{
    public string ID = "";

    public Vector3 Eva(ShotMiko mikosama)
    {
        return mikosama.GetPosition(ID);
    }

    public Vector3 Eva(ShotRule ruler)
    {
        return ruler.GetPosition(ID);
    }

    public string Desc()
    {
        return "記錄座標["+ID+"]";
    }
}
