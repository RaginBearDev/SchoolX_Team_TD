using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool vibor = true;
    public GameObject kirk;
    
    

    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(); // player will shoot by pressing button
        }

    }

    void Shoot() //shooting logic
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void Smena()
    {

    }
}
