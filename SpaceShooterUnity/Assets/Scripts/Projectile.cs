using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public int damageOutput;

    [HideInInspector]
        public GameObject firingShip; //The ship that fired the projectile. So ships dont damage themselves when firing.


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Projectile has detected collison.
        
        if (collision.GetComponent<Ship>() && collision.gameObject != firingShip)
        {
            // Collided object is a ship that is NOT the firing ship.

            collision.GetComponent<Ship>().TakeDamage(damageOutput);

            Destroy(gameObject);

        }
    }

}
