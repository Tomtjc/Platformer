using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour
{
    public DoNotDestroy test;
    public Text deaths;
  



    // Start is called before the first frame update
    void Start()
    {
        test = FindObjectOfType<DoNotDestroy>();        
    }

    // Update is called once per frame
    void Update()
    {
        deaths.text = test.deathcount.ToString("Deaths: 0");
        
    }
}
