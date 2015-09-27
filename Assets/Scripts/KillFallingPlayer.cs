using UnityEngine;
using System.Collections;

public class KillFallingPlayer : MonoBehaviour {
    Transform myTransform;
	// Use this for initialization
	void Start () {
        myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (myTransform.position.y < -6)
        {
            GetComponent<DeadHandler>().Respawn();
        }
	}
}
