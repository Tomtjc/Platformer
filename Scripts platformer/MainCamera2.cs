using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera2 : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;
    private GameObject gravityMan;
    private GameObject pogo;
    private int x = 0;
    private int y = 0;



    public void TargetGravityMan()
    {
        x = 1;
    }

    public void TargetPogo()
    {

        y = 1;
    }
    

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
            pogo = GameObject.FindGameObjectWithTag("Pogo");
            target = pogo.GetComponent<Transform>();
            transform.position = new Vector3(target.position.x, 0f, -10f) + offset;


        }
        else if (x == 1)
        {
            gravityMan = GameObject.FindGameObjectWithTag("GravityMan");
            target = gravityMan.GetComponent<Transform>();
            transform.position = new Vector3(target.position.x, 0f, -10f) + offset;
        }
    }
}
