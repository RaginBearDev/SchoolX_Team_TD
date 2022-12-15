using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosmo_chel : MonoBehaviour
{
    public float speed = 10;
    public float xAxis, yAxis;
    public Transform chel;
    private bool FacingRight = true;
    public GameObject bullets;
    public GameObject[] array_of_objects = new GameObject[5];
    

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

        if (xAxis > 0 && FacingRight)
        {
            Flip();
        }
        else if (xAxis < 0 && !FacingRight)
        {
            Flip();
        }

        Smena();
    }

    private void Flip()
    {

        FacingRight = !FacingRight;
        Vector3 theScale = chel.transform.localScale;
        theScale.x *= -1;
        chel.transform.localScale = theScale;
        bullets.transform.Rotate(0f, 180f, 0f);

    }
    void Smena()
    {
        if (Input.GetKeyDown("1"))
        {
            array_of_objects[0].gameObject.SetActive(true);
            array_of_objects[1].gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("2"))
        {
            array_of_objects[1].gameObject.SetActive(true);

            array_of_objects[0].gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("3"))
        {
            array_of_objects[0].gameObject.SetActive(false);

            array_of_objects[1].gameObject.SetActive(false);
        }
    }
}
