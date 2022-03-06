using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBorder : MonoBehaviour
{
    private GameObject player;
    private GameObject flappy;
    DoNotDestroy death;

   

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        flappy = GameObject.FindGameObjectWithTag("Flappy");
        death = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<DoNotDestroy>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Destroy(player.gameObject);
            death.Death();
        }
        if (collision.tag == "Flappy")
        {

            Destroy(flappy.gameObject);
            death.Death();
        }
    }
}
