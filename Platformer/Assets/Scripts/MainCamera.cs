using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;
    private GameObject player;
    private GameObject flappy;
    private int x = 0;
    private int y = 0;

   

    public void TargetPlayer()
    {
       x = 1;
    }

    public void TargetFlappy ()
    { 
          
        y = 1;
    }
    // Update is called once per frame

   

    private void Update()
    {
        if (target == null)
        {
            transform.position = new Vector3(-3.66f, 0f, -10f) + offset;

        }
        
    }


    private void FixedUpdate()
    {
        if (y == 1)
        {
            flappy = GameObject.FindGameObjectWithTag("Flappy");
            target = flappy.GetComponent<Transform>();
            transform.position = new Vector3(target.position.x, 0f, -10f) + offset;

            
        }
        else if (x==1)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            target = player.GetComponent<Transform>();
            transform.position = new Vector3(target.position.x, 0f, -10f) + offset;
            
        }
    }
}
