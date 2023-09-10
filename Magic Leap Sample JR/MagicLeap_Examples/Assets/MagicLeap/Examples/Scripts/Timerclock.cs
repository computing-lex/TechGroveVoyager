using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerclock : MonoBehaviour
{
    public float timeVal = 90;
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
         if (timeVal > 0)
        {
            timeVal -= Time.deltaTime;
        }
        else
        {
            timeVal =0;
        }
        DisplayTime(timeVal);
    }
    void DisplayTime (float timeToDisplay){
        if(timeToDisplay < 0) {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
