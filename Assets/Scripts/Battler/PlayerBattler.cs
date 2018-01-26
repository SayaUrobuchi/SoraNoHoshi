using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattler : BattlerBase
{
    public const float SPEED = 4f;
    public const float LOW_SPEED = 1.6f;

    public ShotMaid MainShot = new ShotMaid();
    public SpriteRenderer HitHintRef;

    public bool NeedShowHitHint()
    {
        return IsMovable && Input.GetKey(KeyCode.LeftShift);
    }

	// Use this for initialization
	void Start ()
    {
		MainShot.Owner = this;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (IsMovable)
        {
            float speed = (Input.GetKey(KeyCode.LeftShift) ? LOW_SPEED : SPEED);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * speed * StageMaid.DeltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * speed * StageMaid.DeltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * speed * StageMaid.DeltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed * StageMaid.DeltaTime);
            }
        }

        if (IsFireable)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                MainShot.Trigger();
            }
            else
            {
                MainShot.Stop();
            }
        }

        if (HitHintRef != null)
        {
            HitHintRef.enabled = NeedShowHitHint();
        }
    }
}
