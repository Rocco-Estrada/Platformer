using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] private Text clock;
    private float time = 400.0f;

    void Start()
    {
        clock.text = time.ToString();
    }

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            int seconds = (int)time;
            clock.text = seconds.ToString();
        }
        else
            return;
    
    }



}
