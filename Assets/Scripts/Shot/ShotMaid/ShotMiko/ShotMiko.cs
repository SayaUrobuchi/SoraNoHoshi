using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public abstract class ShotMiko : IHasMama<ShotMiko>
{
    public const string GENERATE_POS = "__GENERATE_POS";
    public const string BORN_POS = "__BORN_POS";
    
    public int Index { get; set; }
    public ShotMiko Mama { get; set; }

    protected ShotRule owner;
    protected Shot shot;
    protected Dictionary<string, Vector3> posTable = new Dictionary<string, Vector3>();
    private Dictionary<string, float> valTable = new Dictionary<string, float>();

    public ShotRule Owner
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
            return owner.Battler;
        }
    }

    public Shot Shot
    {
        get
        {
            return shot;
        }
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
        Debug.LogError("不存在的 ShotMiko.posTable["+id+"]");
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
        Debug.LogError("不存在的 ShotMiko::ValTable[" + id + "]");
        return 0f;
    }

    public void GenerateShot(ShotRule ruler)
    {
        owner = ruler;
        posTable = new Dictionary<string, Vector3>();
        posTable[GENERATE_POS] = ruler.Battler.CurrentPos;
        valTable = new Dictionary<string, float>();
        RegisterToStage();
        RealGenerateShot(ruler);
    }

    public void ShotBorn(Shot newShot)
    {
        shot = newShot;
    }

    public void DestroyShot()
    {
        if (shot != null)
        {
            shot.MarkDestroy();
        }
    }

    protected void RegisterToStage()
    {
        StageMaid.Summon.RegisterShotMiko(this);
    }

    public abstract void UpdateShot();
    public abstract bool IsFinished();
    protected abstract void RealGenerateShot(ShotRule ruler);

    #region IHasMama
    public int GetIndex(int grandLevel)
    {
        return this.GetIndexHelper(grandLevel);
    }
    #endregion
}
