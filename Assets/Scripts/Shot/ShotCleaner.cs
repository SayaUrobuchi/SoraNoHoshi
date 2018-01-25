using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCleaner : MonoBehaviour, ICollideTarget
{
    #region ICollideTarget
    public void OnCollideStart(CollideMaid a, CollideMaid b)
    {
        Shot s = b.Owner as Shot;
        if (s != null)
        {
            s.MarkDestroy();
        }
    }

    public void OnCollideEnd(CollideMaid a, CollideMaid b)
    {
    }

    public void OnCollideContinue(CollideMaid a, CollideMaid b)
    {
    }
    #endregion
}
