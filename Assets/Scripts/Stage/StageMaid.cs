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

    public float DeltaTime
    {
        get
        {
            return Mathf.Min(.05f, Time.deltaTime);
        }
    }

    private void Awake()
    {
        self = this;
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
