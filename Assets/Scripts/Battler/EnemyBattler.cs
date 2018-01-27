using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattler : BattlerBase
{
    public int FakeMaxHP = 800;
    public EnemySpellMaid SpellMaid;

    private int currentHP = 1;
    private int currentSpellIndex = 0;
    private ShotMaid currentShotMaid;

    public int MaxHP
    {
        get
        {
            return FakeMaxHP;
        }
    }

    public int CurrentHP
    {
        get
        {
            return currentHP;
        }
    }

    public float HPRate
    {
        get
        {
            return (float)currentHP / MaxHP;
        }
    }

    public override void OnHit(Shot shot)
    {
        base.OnHit(shot);
        currentHP--;
        if (currentHP <= 0)
        {
            UseNextSpell();
        }
    }

    public void UseNextSpell()
    {
        UseSpell((currentSpellIndex+1) % SpellMaid.Spells.Count);
    }

    public void UseSpell(int idx)
    {
        currentSpellIndex = idx;
        UseSpell(SpellMaid.Spells[idx]);
    }

    private void UseSpell(EnemySpell spell)
    {
        if (currentShotMaid != null)
        {
            currentShotMaid.Stop();
            StageMaid.Summon.ClearAllShot();
        }
        FakeMaxHP = spell.MaxHP;
        currentHP = MaxHP;
        currentShotMaid = spell.ActionPattern;
        currentShotMaid.Owner = this;
        currentShotMaid.Trigger();
    }

    // Use this for initialization
    void Start ()
    {
        UseSpell(0);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
