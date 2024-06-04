using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test(1,1.5f,1.25);
        Test(f: 1.5f,i: 1,d: 1.88);
        dynamic d = 1;
        object o = 2;
        print(d.GetType());
        print(o.GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Test(int i,float f,double d) {
        print(i + " " + f + " " + d);
    }
}
