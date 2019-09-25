using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{

    //initialise and set variable types
    public float speed;

    public float bulletLifespan = 150;

    // Destroy bullet on collision
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    private void FixedUpdate()
    {
        // Despawn bullets after period of time
        bulletLifespan--;
        if (bulletLifespan <= 0)
            Object.Destroy(this.gameObject);
    }
}//
