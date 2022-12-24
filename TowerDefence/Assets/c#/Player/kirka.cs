using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirka : MonoBehaviour
{
    public GameObject rad;
    public CircleCollider2D rad1;
    
    
    void Start()
    {

        rad1 = rad.GetComponent<CircleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rad.gameObject.SetActive(false);
        //rad.GetComponent<CircleCollider2D>().enabled = false;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        rad.gameObject.SetActive(true);
    }
}
