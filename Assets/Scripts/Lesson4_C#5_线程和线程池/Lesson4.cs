using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    Thread thread;
    // Start is called before the first frame update
    void Start()
    {
        //thread = new Thread(()=> {
        //    while(true) {
        //        print("123");
        //        Thread.Sleep(1000);
        //    }
        //});
        //thread.Start();
        //print("主线程执行");
        int num1;
        int num2;
        ThreadPool.GetAvailableThreads(out num1,out num2);
        print(num1);
        print(num2);
    }
    private void OnDestroy() {
        //thread.Abort();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
