using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollideTarget
{
    void OnCollideStart(CollideMaid a, CollideMaid b);
    void OnCollideEnd(CollideMaid a, CollideMaid b);
    void OnCollideContinue(CollideMaid a, CollideMaid b);
}
