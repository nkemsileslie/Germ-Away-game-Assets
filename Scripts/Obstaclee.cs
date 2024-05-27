using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclee : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        
    }

    private void onTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
