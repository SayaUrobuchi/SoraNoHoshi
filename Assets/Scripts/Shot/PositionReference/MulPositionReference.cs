using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulPositionReference : PositionReference
{
    public PositionReference Left = new CustomVectorPositionReference();
    public IValue<ShotMiko> Right = new ConstValue<ShotMiko>(1f);

    public override Vector3 GetPos(ShotMiko mikosama)
    {
        return Left.GetPos(mikosama) * Right.Eva(mikosama);
    }
}
