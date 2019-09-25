using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //initialise and set variable types
    CharacterController player;
    private Vector3 moveDirection;
    public float speed = 8.0f;
    public float gravity = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //when player is grounded, recieve movement inputs for up/down left/right
        if (player.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
        }

        //move the player
        moveDirection.y -= gravity * Time.deltaTime;
        player.Move(moveDirection * Time.deltaTime);
    }
}
//