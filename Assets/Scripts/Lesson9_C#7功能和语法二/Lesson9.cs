using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        (int i, string str, double d) = (5, "123", 5.0);
        print(i);
        (int i, string str, double d) yz = (5, "123", 5.0);
        print(yz.i);
        object o = 1;
        if(o is var v) {
            print(v);
        }
    }
    private string jsonStr;
    private void InitInfo(string str) => jsonStr = str ?? throw new System.ArgumentNullException(nameof(str));
    private string GetInfo(string str,int index) {
        string[] strs = str.Split(',');
        return strs.Length > index ? strs[index] : throw new System.ArgumentOutOfRangeException(nameof(index));
    }
    private (string, int, float) GetInfo() {
        return ("123", 2, 5.5f); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
