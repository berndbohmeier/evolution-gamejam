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
        if (transform.position.y < -6)
        {
            Application.LoadLevel(2);
        }
	}
}
