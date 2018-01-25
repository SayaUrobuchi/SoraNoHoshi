using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class CollideMaid : SerializedMonoBehaviour
{
    public enum Type
    {
        Undefined, 
        PlayerBattler, 
        EnemyBattler, 
        PlayerShot, 
        EnemyShot, 
        ShotCleaner, 
    }

    public ICollideTarget Owner;
    public Type Tag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Owner != null)
        {
            CollideMaid aite = collision.GetComponent<CollideMaid>();
            if (aite != null)
            {
                Owner.OnCollideStart(this, aite);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Owner != null)
        {
            CollideMaid aite = collision.GetComponent<CollideMaid>();
            if (aite != null)
            {
                Owner.OnCollideEnd(this, aite);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Owner != null)
        {
            CollideMaid aite = collision.GetComponent<CollideMaid>();
            if (aite != null)
            {
                Owner.OnCollideContinue(this, aite);
            }
        }
    }
}
