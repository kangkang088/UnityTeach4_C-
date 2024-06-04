using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    private bool isRunning = true;
    CancellationTokenSource cts;
    // Start is called before the first frame update
    void Start()
    {
        //1.
        //Task t1 = new Task(() => {
        //    int i = 0;
        //    while(isRunning) {
        //        print("��ʽһ��" + i);
        //        ++i;
        //        Thread.Sleep(1000);
        //    }
        //});
        //t1.Start();
        ////2.
        //Task t2 = Task.Run(() => {
        //    int i = 0;
        //    while(isRunning) {
        //        print("��ʽ����" + i);
        //        ++i;
        //        Thread.Sleep(1000);
        //    }
        //});
        ////3.
        //Task t3 = Task.Factory.StartNew(() => {
        //    int i = 0;
        //    while(isRunning) {
        //        print("��ʽ����" + i);
        //        ++i;
        //        Thread.Sleep(1000);
        //    }
        //});

        //�첽-����
        //Task t = new Task(() => 
        //{
        //    Thread.Sleep(1000);
        //    print("������");
        //});
        //t.Start();
        //print("���߳�ִ��");

        //ͬ��-����
        //Task t2 = new Task(() => {
        //    Thread.Sleep(1000);
        //    print("������");
        //});
        //t2.RunSynchronously();
        //print("���߳�ִ��");

        //Task t1 = Task.Run(() => {
        //    for(int i = 0;i < 5;i++) {
        //        print("t1-" + i);
        //    }
        //});
        //Task t2 = Task.Run(() => {
        //    for(int i = 0;i < 20;i++) {
        //        print("t2-" + i);
        //    }
        //});
        //Task.WhenAll(t1,t2).ContinueWith((a) => {

        //});
        //print("���߳�ִ��");

        //CancellationTokenSource
        cts = new CancellationTokenSource();
        Task.Run(() => {
            int i = 0;
            while(!cts.IsCancellationRequested) {
                print("��ʱ��" + i);
                i++;
                Thread.Sleep(1000);
            }
        });
    }
    private void OnDestroy() {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            cts.Cancel();
        }
    }
}
