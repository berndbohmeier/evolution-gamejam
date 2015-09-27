using UnityEngine;
using System.Collections;

public class DeadHandler : MonoBehaviour {

    Vector2 respawnPosition;


	// Use this for initialization
	void Start () {
        respawnPosition = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void Respawn()
    {
        GetComponent<Transform>().position = new Vector3(respawnPosition.x, respawnPosition.y,0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    public void SetRespawn(float x, float y)
    {
        respawnPosition = new Vector2(x, y);
    }
}
