using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    private GameObject gravityMan;
    private GameObject pogo;
    public GameObject gravityManPrefab;
    public GameObject pogoPrefab;
    private int x = 0;
    private int y = 0;


    private void Awake()
    {
        Time.timeScale = 0f;

    }

    public void Pogo()
    {
        x = 1;
    }
    public void GravityMan()
    {
        y = 1;
    }


    private void Update()
    {
        if (Input.GetKey("space"))
        {
            Time.timeScale = 1f;
        }

        //if (Input.GetKey(KeyCode.Escape))
        //{
        //    Application.Quit();
        //}

        if (x == 1)
        {
            pogo = GameObject.FindGameObjectWithTag("Pogo");
            if (pogo == null)
            {
                Time.timeScale = 0f;
                GameObject a = Instantiate(pogoPrefab) as GameObject;
                a.transform.position = new Vector2(-3.66f, -0.61f);

            }
        }
        if (y == 1)
        {
            gravityMan = GameObject.FindGameObjectWithTag("GravityMan");
            if (gravityMan == null)
            {
                Time.timeScale = 0f;
                GameObject b = Instantiate(gravityManPrefab) as GameObject;
                b.transform.position = new Vector2(-3.66f, -0.61f);

            }
        }
    }
}
