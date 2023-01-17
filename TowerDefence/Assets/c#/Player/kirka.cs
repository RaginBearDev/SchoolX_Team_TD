using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirka : MonoBehaviour
{
    public CircleCollider2D rad1;
    
 
    // Update is called once per frame
    void Update()
    {
        rad1.enabled = false;
        //rad.GetComponent<CircleCollider2D>().enabled = false;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        rad1.enabled = true;
    }
}
