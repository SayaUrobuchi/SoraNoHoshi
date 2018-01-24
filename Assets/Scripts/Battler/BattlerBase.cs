using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class BattlerBase : SerializedMonoBehaviour, ICollideTarget
{
    public Transform FirePosition;

    public bool IsMovable
    {
        get
        {
            return true;
        }
    }

    public bool IsFireable
    {
        get
        {
            return true;
        }
    }

    public virtual void Fire()
    {
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #region ICollideTarget
    public void OnCollideStart(CollideMaid a, CollideMaid b)
    {
    }

    public void OnCollideEnd(CollideMaid a, CollideMaid b)
    {
    }

    public void OnCollideContinue(CollideMaid a, CollideMaid b)
    {
    }
    #endregion
}
