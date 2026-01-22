using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public float acceleration;
    public float currentSpeed;
    public float maxSpeed;

    public float fireRate;
    public float projectileVelocity;

    public Rigidbody2D rb;

    public GameObject projectilePrefab;

    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    public void Thrust()
    {
        rb.AddForce(transform.up * acceleration);
    }

    public void FireProjectile()
    {
        GameObject newProjectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, transform.rotation);
        newProjectile.GetComponent<Rigidbody2D>().AddForce(transform.up * projectileVelocity);
        Destroy(newProjectile, 4);
    }

    public void TakeDamage()
    { 
    
    }

    public void Explode()
    { 
    
    }
}
