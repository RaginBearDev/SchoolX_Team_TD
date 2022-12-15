using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Test : MonoBehaviour
{

    float HP = 1000;
    float Shield_HP = 0;
    float Range = 7;
    float Speed = 10;
    float Damage = 10;
    float CoolDown = 1;
    float CurrentCoolDown = 0;

    public GameObject Projectile;

    bool CanShoot()
    {
        if (CurrentCoolDown <= 0)
            return true;
         return false;
    }

    void SearchTarget()
    {
        Transform nearestEnemy = null;
        float nearestEnemyDistance = Mathf.Infinity;

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("igrok"))
        {
            float currDistance = Vector2.Distance(transform.position, enemy.transform.position);

            if ((currDistance < nearestEnemyDistance) && (currDistance <= Range))
            {
                nearestEnemy = enemy.transform;
                nearestEnemyDistance = currDistance;
            }
        }

        if (nearestEnemy != null)
        {
            Shoot(nearestEnemy);
        }
    }

    void Shoot(Transform enemy)
    {
        CurrentCoolDown = CoolDown;
        Debug.Log("Shoot");

        GameObject proj = Instantiate(Projectile);
        proj.transform.position = transform.position;
        proj.GetComponent<Tower_Projectile>().SetTarget(enemy);
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (CanShoot())
            SearchTarget();

        if (CurrentCoolDown > 0) 
        {
            CurrentCoolDown -= Time.deltaTime;
        }
    }
}
