using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class SingleShotMiko : ShotMiko
{
    public List<ShotLifeplan> Plans = new List<ShotLifeplan>();

    protected int planIndex = 0;
    protected bool shotCleaned = false;

    protected override void RealGenerateShot(ShotRule ruler)
    {
        planIndex = 0;
    }

    public override void UpdateShot()
    {
        if (shot != null && shot.IsFinished)
        {
            GameObject.Destroy(shot.gameObject);
            shot = null;
            shotCleaned = true;
            return;
        }

        if (planIndex < Plans.Count)
        {
            Plans[planIndex].Execute(this);
            if (Plans[planIndex].IsFinished(this))
            {
                planIndex++;
            }
        }
    }

    public override bool IsFinished()
    {
        return shotCleaned || planIndex >= Plans.Count;
    }
}
