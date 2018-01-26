using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMaid : MonoBehaviour
{
    private static StageMaid self;
    public static StageMaid Summon
    {
        get
        {
            return self;
        }
    }

    public static float DeltaTime
    {
        get
        {
            return Mathf.Min(.05f, Time.deltaTime);
        }
    }

    public EnemyBattler MainEnemy;

    private List<ShotMiko> shots = new List<ShotMiko>();

    public void RegisterShotMiko(ShotMiko miko)
    {
        shots.Add(miko);
    }

    public EnemyBattler GetMainEnemy()
    {
        return MainEnemy;
    }

    private void Awake()
    {
        self = this;
    }

    // Use this for initialization
    void Start ()
    {
		
	}

    private void FixedUpdate()
    {
        for (int i = 0; i < shots.Count; i++)
        {
            shots[i].UpdateShot();
        }
        int lim = 0;
        for (int i = 0; i < shots.Count; i++)
        {
            if (!shots[i].IsFinished())
            {
                shots[lim++] = shots[i];
            }
        }
        shots.TrimTo(lim);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
