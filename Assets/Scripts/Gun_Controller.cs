using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Controller : MonoBehaviour
{
    //initialise and set variable types
    public bool isFiring;

    public Bullet_Controller bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    public Money_Manager money;
    public int bulletCost = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate bullets, with cooldown
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                Bullet_Controller newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;

                money.reduceBy(bulletCost);
            }
        }
        else
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
                shotCounter = 0;
        }

    }
}//
