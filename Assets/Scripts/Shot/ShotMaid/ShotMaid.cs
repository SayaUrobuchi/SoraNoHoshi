using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ShotMaid : SerializedMonoBehaviour
{
    public List<ShotRule> Rules = new List<ShotRule>();

    private BattlerBase owner;
    private bool triggered = false;

    public BattlerBase Owner
    {
        get
        {
            return owner;
        }

        set
        {
            owner = value;
        }
    }

    public bool IsTriggered
    {
        get
        {
            return triggered;
        }
    }

    public void Trigger()
    {
        triggered = true;
    }

    public void Stop()
    {
        triggered = false;
    }

    private void Start()
    {
        for (int i = 0; i < Rules.Count; i++)
        {
            Rules[i].SetOwner(this);
        }
    }
}
