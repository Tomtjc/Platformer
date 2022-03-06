using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private GameObject gravityMan;
    private GameObject pogo;
    

    DoNotDestroy death;

    void Start()
    {
        death = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<DoNotDestroy>();
    }

    private void FixedUpdate()
    {
           
        player = GameObject.FindGameObjectWithTag("Player"); 
        gravityMan = GameObject.FindGameObjectWithTag("GravityMan");
        pogo = GameObject.FindGameObjectWithTag("Pogo");
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
            death.Death();
        }

        if (collision.tag == "GravityMan")
        {
            Destroy(gravityMan.gameObject);
            death.Death();
        }

        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);

        }

        if (collision.tag == "Pogo")
        {
            Destroy(pogo.gameObject);
            death.Death();
        }
    }
}
