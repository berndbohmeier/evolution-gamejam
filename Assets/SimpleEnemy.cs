using UnityEngine;
using System.Collections;

public class SimpleEnemy : MonoBehaviour {

    public Transform left;
    public Transform right;
    private Transform player;
    private Transform my;
    public float minDistance;
    private MoveController move;
    private int dir = -1;
    private float closeDistance = 1;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        my = GetComponent<Transform>();
        move = GetComponent<MoveController>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = player.position.x - my.position.x;
        if (Mathf.Abs(distance) < minDistance)
        {
            move.Move(Mathf.Sign(distance));
        }
        else
        {
            if(left != null && right != null)
            {
                if(dir == -1)
                {
                    distance = left.position.x - my.position.x;
                    move.Move(Mathf.Sign(distance));
                    
                }
                else
                {
                    distance = right.position.x - my.position.x;
                    move.Move(Mathf.Sign(distance));
                }
                if (Mathf.Abs(distance) < closeDistance)
                {
                    dir *= -1;
                }
            }
        }
	}
}
