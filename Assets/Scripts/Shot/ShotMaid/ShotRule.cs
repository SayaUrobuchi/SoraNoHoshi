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
    private Dictionary<string, Vector3> posTable = new Dictionary<string, Vector3>();
    private Dictionary<string, float> valTable = new Dictionary<string, float>();

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

    public void SetPosition(string id, Vector3 pos)
    {
        posTable[id] = pos;
    }

    public Vector3 GetPosition(string id)
    {
        if (posTable.ContainsKey(id))
        {
            return posTable[id];
        }
        Debug.LogError("不存在的 ShotRule::PosTable[" + id + "]");
        return Vector3.zero;
    }

    public void SetValue(string id, float pos)
    {
        valTable[id] = pos;
    }

    public float GetValue(string id)
    {
        if (valTable.ContainsKey(id))
        {
            return valTable[id];
        }
        Debug.LogError("不存在的 ShotRule::ValTable[" + id + "]");
        return 0f;
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
