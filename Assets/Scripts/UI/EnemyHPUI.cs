using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class EnemyHPUI : SerializedMonoBehaviour
{
    public const int HEIGHT = 384;

    public Image Front;

    private EnemyBattler mainEnemy;

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
            Front.GetComponent<RectTransform>().sizeDelta = new Vector2(0, HEIGHT * mainEnemy.HPRate);
        }
	}
}
