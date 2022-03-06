using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerz : MonoBehaviour
{
    public DoNotDestroy test;
    public Text timerz;



    // Start is called before the first frame update
    void Start()
    {
        test = FindObjectOfType<DoNotDestroy>();
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    }

    // Update is called once per frame
    void Update()
    {
        timerz.text = test.timers.ToString("Time: 0.00");
    }
}