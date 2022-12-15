using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Projectile : MonoBehaviour
{ 

    Transform target;
    float speed = 7;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void SetTarget(Transform enemy)
    {
        target = enemy;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void Move()
    {

        if (target != null)
        {
            //if (Vector2.Distance(transform.position, target.position) < 0.1f)
            //   Destroy(gameObject);
            //else

            
            {
                Vector2 dir = target.position - transform.position;

                transform.Translate(dir.normalized * Time.deltaTime * speed);
            }
        }
        else Destroy(gameObject);
    }
}
