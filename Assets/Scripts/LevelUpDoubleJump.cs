﻿using UnityEngine;
using System.Collections;

public class LevelUpDoubleJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<MoveController>().timesJump = 2;
        }

    }
}
