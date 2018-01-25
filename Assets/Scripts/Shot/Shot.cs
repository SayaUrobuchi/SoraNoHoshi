using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Shot : SerializedMonoBehaviour, ICollideTarget
{
    public BattlerBase Owner;

    private bool isFinished = false;

    public bool IsFinished
    {
        get
        {
            return isFinished;
        }
    }

    public void MarkDestroy()
    {
        isFinished = true;
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

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
