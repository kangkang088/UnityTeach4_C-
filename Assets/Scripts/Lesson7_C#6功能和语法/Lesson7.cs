using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;
using static Test;

public class Test {
    public static void TestMethod() {
        Debug.Log("123");
    }
}
public class Lesson7 : MonoBehaviour
{
    void Start()
    {
        Max(10,20);
        TestMethod();
        int i = 0;
        print(nameof(i));
        print(nameof(List<int>));
    }
    void Update()
    {
        
    }
}
