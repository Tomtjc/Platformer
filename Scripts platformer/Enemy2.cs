using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy2 : MonoBehaviour
{

    private GameObject player;
    private GameObject flappy;
    DoNotDestroy death;
    
    void Start()
    {
        death = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<DoNotDestroy>();
    }
    
    private void FixedUpdate()
    {
                              
        player = GameObject.FindGameObjectWithTag("Player");
                        
    }
    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            Destroy(this.gameObject);
        }        
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
            death.Death();

        }
       
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
