using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPositionReference : PositionReference
{
    public PositionReference Left = new CustomVectorPositionReference();
    public PositionReference Right = new CustomVectorPositionReference();

    public override Vector3 GetPos(ShotMiko mikosama)
    {
        return Left.GetPos(mikosama) + Right.GetPos(mikosama);
    }
}
