using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirka : MonoBehaviour
{
    public GameObject rad;
    void Start()
    {
        rad = GameObject.FindGameObjectWithTag("radius_kirka");
        
    }

    // Update is called once per frame
    void Update()
    {

        rad.GetComponent<CircleCollider2D>().enabled = false;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        rad.GetComponent<CircleCollider2D>().enabled = true;
    }
}
