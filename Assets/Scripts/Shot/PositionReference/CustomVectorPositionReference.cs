using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomVectorPositionReference : PositionReference
{
    [SelfDesc]
    public IValue<ShotMiko> X = new ConstValue<ShotMiko>(0f);
    [SelfDesc]
    public IValue<ShotMiko> Y = new ConstValue<ShotMiko>(0f);

    public override Vector3 GetPos(ShotMiko mikosama)
    {
        return new Vector3(X.Eva(mikosama), Y.Eva(mikosama));
    }
}
