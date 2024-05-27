using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclee : MonoBehaviour
{
    private GameObject player;

    // Update is called once per frame
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");    
    }

    private void onTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
