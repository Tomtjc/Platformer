using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private GameObject player;
    private GameObject flappy;
    public GameObject playerPrefab;
    public GameObject flappyPrefab;
    private int x = 0;
    private int y = 0;
    

    private void Awake()
    {
        Time.timeScale = 0f;
        
    }

    public void Flappy()
    {
        x = 1;
    }
    public void Player()
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

            if (x==1)
        {
            flappy = GameObject.FindGameObjectWithTag("Flappy");
            if (flappy == null)
            {
                Time.timeScale = 0f;
                GameObject a = Instantiate(flappyPrefab) as GameObject;
                a.transform.position = new Vector2(-3.66f, -0.61f);
                
            }
        }
        if (y==1)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            if (player == null)
            {
                Time.timeScale = 0f;
                GameObject b = Instantiate(playerPrefab) as GameObject;
                b.transform.position = new Vector2(-3.66f, -0.61f);
                
            }
        }
    }
}
