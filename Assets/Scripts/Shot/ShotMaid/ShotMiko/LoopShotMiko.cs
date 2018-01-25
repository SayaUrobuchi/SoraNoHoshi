using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopShotMiko : ShotMiko
{
    public ShotMiko MikoTemplate;
    public int LoopCount = 2;

    protected List<ShotMiko> mikos = new List<ShotMiko>();
    protected bool isFinished = false;

    protected override void RealGenerateShot(ShotRule ruler)
    {
        mikos = new List<ShotMiko>();
        for (int i = 0; i < LoopCount; i++)
        {
            ShotMiko m = MikoTemplate.Duplicate();
            m.Mama = this;
            m.Index = i;
            m.GenerateShot(ruler);
            mikos.Add(m);
        }
    }

    public override void UpdateShot()
    {
        bool flag = true;
        for (int i = 0; i < mikos.Count; i++)
        {
            if (!mikos[i].IsFinished())
            {
                mikos[i].UpdateShot();
            }
            flag = (flag && mikos[i].IsFinished());
        }
        isFinished = isFinished || flag;
    }

    public override bool IsFinished()
    {
        return isFinished;
    }
}
