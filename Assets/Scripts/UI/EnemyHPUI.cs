using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class EnemyHPUI : SerializedMonoBehaviour
{
    public const int HEIGHT = 384;
    public const float SPEED = .8f;

    public Image Front;

    private EnemyBattler mainEnemy;
    private float displayAmount = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (mainEnemy == null)
        {
            mainEnemy = StageMaid.Summon.MainEnemy;
        }
        if (mainEnemy != null)
        {
            float realRate = mainEnemy.HPRate;
            if (displayAmount < realRate)
            {
                displayAmount = Mathf.Min(displayAmount + StageMaid.DeltaTime * SPEED, realRate);
            }
            else if (displayAmount > realRate)
            {
                displayAmount = Mathf.Max(displayAmount - StageMaid.DeltaTime * SPEED, realRate);
            }
            Front.GetComponent<RectTransform>().sizeDelta = new Vector2(0, HEIGHT * displayAmount);
        }
	}
}
