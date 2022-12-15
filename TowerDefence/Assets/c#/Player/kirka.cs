using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirka : MonoBehaviour
{
    public CircleCollider2D udar;
    public GameObject radius;
    void Start()
    {

        radius.GetComponent<CircleCollider2D>().enabled = false;
        udar = GetComponent<CircleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //kirochka.GetComponent<CircleCollider2D>().enabled = true;
    }
}
