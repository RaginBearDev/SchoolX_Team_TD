using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosmo_chel : MonoBehaviour
{
    public float speed = 10;
    public float xAxis, yAxis;
    public Transform chel;

    void Start()
    {
        chel = GetComponent<Transform>();    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "platform")
        {
            Debug.Log("Wall! U can't go this way");
        }
    }

    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        yAxis = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(xAxis, yAxis, 0);
        chel.Translate(moveVector * speed * Time.deltaTime);
    }
}
