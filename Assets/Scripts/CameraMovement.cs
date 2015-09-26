using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    Transform playerTransform;
    Transform myTransform;

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        myTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        myTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, myTransform.position.z);

	}
}
