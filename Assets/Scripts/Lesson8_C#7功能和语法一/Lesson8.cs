using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    void Start()
    {
        print(Test(10));
    }
    public int Test(int i) {
        bool b = false;
        i += 10;
        Calc();
        print(b);
        return i;

        void Calc() {
            i += 10;
            b = true;
        }
    }
    void Update()
    {
        
    }
}
