using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class trees : MonoBehaviour
{
    GameObject tree;
    int hptree = 1000;

    private void Start()
    {
        tree = GameObject.FindGameObjectWithTag("tree");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "radius_kirka")
        {
            hptree -= 10;
            Debug.Log(hptree);
        }
    }

    void Update()
    {
        if(hptree == 0)
        {
            TreeDestroy();
        }
    }
    void TreeDestroy()
    {
        Destroy(tree);

    }
}
