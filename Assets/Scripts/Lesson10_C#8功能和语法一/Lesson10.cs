using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Person {
    public string name;
    public int age;
    public bool sex;
}
public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        using(StreamWriter sw = new StreamWriter("")) {
            sw.Write(true);
            sw.Flush();
            sw.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
