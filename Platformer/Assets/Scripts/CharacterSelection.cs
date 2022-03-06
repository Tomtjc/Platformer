using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSelection : MonoBehaviour
{
    public GameObject player;
    public GameObject flappy;

    // Start is called before the first frame update
    

    public void LoadRegular()
    {
        Destroy(this.gameObject);
        GameObject b = Instantiate(player) as GameObject;
        b.transform.position = new Vector2(-3.66f, -0.61f);
    }
    public void LoadFlappy()
    {
        Destroy(this.gameObject);
        GameObject a = Instantiate(flappy) as GameObject;
        a.transform.position = new Vector2(-3.66f, -0.61f);
        
    }

}
