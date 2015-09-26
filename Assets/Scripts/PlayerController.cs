using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    MoveController move;
    void Start()
    {
        move = GetComponent<MoveController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            move.Jump();
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        move.Move(h);
    }
}

   