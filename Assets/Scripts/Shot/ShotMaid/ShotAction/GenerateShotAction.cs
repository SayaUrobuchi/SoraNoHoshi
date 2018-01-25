using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class GenerateShotAction : ShotAction
{
    public ShotMiko ShotData;

    public override void Execute(ShotRule master)
    {
        ShotMiko miko = ShotData.Duplicate();
        miko.GenerateShot(master);
    }
}
