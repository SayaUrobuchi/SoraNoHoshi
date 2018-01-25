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

    public void GenerateShot(ShotRule ruler)
    {
        owner = ruler;
        posTable = new Dictionary<string, Vector3>();
        posTable[GENERATE_POS] = ruler.Battler.CurrentPos;
        RegisterToStage();
        RealGenerateShot(ruler);
    }

    public void ShotBorn(Shot newShot)
    {
        shot = newShot;
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
