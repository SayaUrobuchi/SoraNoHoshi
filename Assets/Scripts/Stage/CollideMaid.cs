using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class CollideMaid : SerializedMonoBehaviour
{
    public ICollideTarget Owner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("AAAAAAAA");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }
}
