using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viking : MonoBehaviour
{
    public double vik_hp = 3;
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "firepoint")
        {
            vik_hp -= 1;
            Debug.Log(vik_hp);
        }
        if (collision.tag == "radius_kirka")
        {
            vik_hp -= 0.5;
            Debug.Log(vik_hp);
        }
    }

    void Update()
    {
        if(vik_hp == 0)
        {
            vik_dead();
        }
    }
    void vik_dead()
    {
        Destroy(gameObject);
        Debug.Log("asdaskdj");
    }
}
