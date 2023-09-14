using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float timeLeft = 20;
    public bool timeON = false;
    public TMP_Text timerTxt = null;
    private float fixedtime;

    // Start is called before the first frame update
    void Start()
    {
        timeON = true;
        timerTxt.text = string.Empty;
        fixedtime = timeLeft;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeON)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                Debug.LogWarning("Times UP ...");
                timerTxt.text = "Times UP ,,,,";
                // timeON = false;
                timeLeft = fixedtime;

            }
        }
        DisplayTime(timeLeft);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
  
    }

}
