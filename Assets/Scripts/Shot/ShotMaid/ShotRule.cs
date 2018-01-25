using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ShotRule : SerializedMonoBehaviour
{
    public bool Loop = true;
    public List<ShotAction> Actions = new List<ShotAction>();

    private int actionIndex = 0;
    private float timer = 0f;
    private ShotAction currentAction = null;
    private ShotMaid owner;

    public float Timer
    {
        get
        {
            return timer;
        }

        set
        {
            timer = value;
        }
    }

    public ShotMaid Owner
    {
        get
        {
            return owner;
        }
    }

    public BattlerBase Battler
    {
        get
        {
            return owner.Owner;
        }
    }

    public void SetOwner(ShotMaid master)
    {
        owner = master;
    }

    public void Reset()
    {
        actionIndex = 0;
    }

    private void FixedUpdate()
    {
        if (timer > 0f)
        {
            timer -= StageMaid.DeltaTime;
            return;
        }

        if (currentAction != null)
        {
            currentAction.Execute(this);
            if (currentAction.IsFinish(this))
            {
                currentAction = null;
            }
        }
        else if (owner.IsTriggered)
        {
            currentAction = GetNextAction();
        }
    }

    public ShotAction GetNextAction()
    {
        if (actionIndex >= Actions.Count && Loop)
        {
            Reset();
        }

        if (actionIndex >= Actions.Count)
        {
            return null;
        }
        return Actions[actionIndex++];
    }
}
