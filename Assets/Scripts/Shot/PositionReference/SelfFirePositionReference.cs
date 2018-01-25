using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfFirePositionReference : PositionReference
{
    public string FirePosID = "Fire";

    public override Vector3 GetPos(ShotMiko mikosama)
    {
        return mikosama.Battler.GetFirePosition(FirePosID);
    }
}
