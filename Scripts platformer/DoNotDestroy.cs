using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    public int deathcount = 0;
    public int x = 1;
    [SerializeField] public float timers = 0;

    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainMenu"))
        {
            deathcount = 0;
            timers = 0;
        }



        if (Input.GetKey("space"))
        {
            x = 1;
        }
    }

    private void FixedUpdate()
    {
        if (Time.timeScale != 0 && SceneManager.GetActiveScene() != SceneManager.GetSceneByName("GEFELICITEERD") && SceneManager.GetActiveScene() != SceneManager.GetSceneByName("GEFELICITEERD2"))
        {
            timers += 0.02f;
        }
    }
    
    public void Death()
    {
        if (x == 1)
        {
            deathcount++;
            x = 0;
        }        
    }

}
