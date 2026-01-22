using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : Ship
{

    Transform target;

    // Start is called before the first frame update
    void Start()
    {

        target = FindObjectOfType<PlayerShip>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    void FollowTarget()
    {

        float directionToFaceX = target.position.x - transform.position.x;
        float directionToFaceY = target.position.y - transform.position.y;
        
        Vector2 directionToFace = new Vector2(directionToFaceX, directionToFaceY);

        transform.up = directionToFace;
        Thrust();

    }



}
