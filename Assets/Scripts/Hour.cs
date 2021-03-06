﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hour : MonoBehaviour {
    public float accumulated = 0.0f;
    public int second;
    public int minute ;
    public int hour;
    public int hourPrefab;

    public string amPM;

    public Text time;

	// Use this for initialization
	void Start () {
        amPM = "a.m.";
        accumulated = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        accumulated += Time.deltaTime* 1440.0f;
        second = (int)(accumulated % 60);
        minute = (int)((accumulated / 60) % 60);
        hour = (int)((accumulated / 3600) % 24);
        
        if(hour>= 12)
        {            
            amPM = "p.m.";
            //if (hour >= 13)
            //    hour = hour % 12;
        }
        else
        {
            amPM = "a.m.";
        }
        
        time.text = (hour%12==0?12:hour%12/*hour*/ ).ToString() + ":" + minute.ToString("00") + " " + amPM;
	}
}
