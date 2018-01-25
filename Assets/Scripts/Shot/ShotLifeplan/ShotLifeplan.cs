using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShotLifeplan
{
    public abstract bool IsFinished(ShotMiko mikosama);
    public abstract void Execute(ShotMiko mikosama);
}
