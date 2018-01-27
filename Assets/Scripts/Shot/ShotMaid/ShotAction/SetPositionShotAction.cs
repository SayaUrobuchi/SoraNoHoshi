using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionShotAction : ShotAction
{
    public string PosID = "pos0";
    [SelfDesc]
    public IPositionReference<ShotRule> Pos = new CustomVectorPositionReference<ShotRule>();

    public override void Execute(ShotRule master)
    {
        master.SetPosition(PosID, Pos.Eva(master));
    }
}
