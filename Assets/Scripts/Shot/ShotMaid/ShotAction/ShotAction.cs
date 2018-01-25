using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public abstract class ShotAction
{
    public virtual void Init(ShotRule master)
    {
    }

    public virtual bool IsFinish(ShotRule master)
    {
        return true;
    }

    public abstract void Execute(ShotRule master);
}
