using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        // targeting player 
        player = GameObject.FindGameObjectWithTag("Player");
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy obstacle when it passed the border
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        // destroy player when he hit the obstacle
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);

        }
    }
}
