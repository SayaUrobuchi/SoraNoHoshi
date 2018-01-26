using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattler : BattlerBase
{
    public int FakeMaxHP = 800;

    private int currentHP = 1;

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
        if (currentHP == 0)
        {
            currentHP = FakeMaxHP;
        }
    }

    // Use this for initialization
    void Start ()
    {
		currentHP = FakeMaxHP;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
