using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    //initialise and set variable types
    public Money_Manager money;
    int movementCostDelay = 60;

    CharacterController player;

    public Gun_Controller gun;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Subtract money when moving
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            movementCostDelay--;
            if (movementCostDelay <= 0)
            {
                movementCostDelay = 60;
                money.reduceBy(10);

            }
        }

        /* Player rotation is affecting movement
               
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }*/

    }

    private void Update()
    {
        // Toggle fire for attached gun gameobject
        if (Input.GetMouseButtonDown(0))
        {
            gun.isFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            gun.isFiring = false;
        }
    }
}
//