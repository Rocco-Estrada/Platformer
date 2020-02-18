using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] private Text clock;
    private int time = 400;

    void Start()
    {
        clock.text = time.ToString();
    }

    void Update()
    {
           
        time--;
        clock.text = time.ToString();
    
    }



}
