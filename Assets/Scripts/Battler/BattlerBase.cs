using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class BattlerBase : SerializedMonoBehaviour, ICollideTarget
{
    public Dictionary<string, FirePosition> FirePositionTable = new Dictionary<string, FirePosition>();
    public Transform HitCenter;

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

    public Vector3 CurrentPos
    {
        get
        {
            return HitCenter.position;
        }
    }

    public Vector3 GetFirePosition(string id)
    {
        if (FirePositionTable.ContainsKey(id))
        {
            return FirePositionTable[id].transform.position;
        }

        Debug.LogError("不存在的 FirePosition ["+id+"]");
        return Vector3.zero;
    }

    public Vector3 GetFirePositionOffset(string id)
    {
        return CurrentPos - GetFirePosition(id);
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
