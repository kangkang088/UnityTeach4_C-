using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = new DateTime();
        print("year: " + dt.Year + ",monthe: " + dt.Month + ",day: " + dt.Day + ",hour: " + dt.Hour + ",minute: " + dt.Minute + ",second: " + dt.Second + ",millisecond: " + dt.Millisecond);
        DateTime nowTime = DateTime.Now;

        TimeSpan ts = DateTime.Now - new DateTime(1970,1,1,0,0,0,0);
        print(ts.TotalMinutes);
        print(ts.TotalSeconds);
        print(ts.TotalHours);
        print(ts.TotalDays);
        print(ts.Ticks);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
