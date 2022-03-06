using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection2 : MonoBehaviour
{
    public GameObject gravityMan;
    public GameObject pogo;

    // Start is called before the first frame update


    public void LoadGravityMan()
    {
        Destroy(this.gameObject);
        GameObject b = Instantiate(gravityMan) as GameObject;
        b.transform.position = new Vector2(-3.66f, -0.61f);
    }
    public void LoadPogo()
    {
        Destroy(this.gameObject);
        GameObject a = Instantiate(pogo) as GameObject;
        a.transform.position = new Vector2(-3.66f, -0.61f);

    }
}
