using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Initialise variables
    public GameObject player;

    public Money_Manager money;

    public int enemyMoney = 500;

    public Bullet_Controller bullet;
    public float bulletSpeed;
    public float timeBetweenShots;
    private float shotCounter;
    public Transform firePoint;


    // Player steals money when this enemy collides with a bullet
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            enemyMoney -= 100;
            money.increaseBy(10);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Checks if player is in radius
        Vector3 offset = player.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;


        if (sqrLen < 81)
        {
            // Look at player
            transform.LookAt(player.transform);

            // Fire
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                Bullet_Controller newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;
            }


        }

        // Destuct when money runs out
        if (enemyMoney <= 0)
        {
            Object.Destroy(this.gameObject);
            money.increaseBy(100);
        }

    }
}//