using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;

public class Coroutine2 : MonoBehaviour
{
    

    public void LoadCoroutine()
    {
       
        Debug.Log("Message 1");
        StartCoroutine(CoroutineMethod());
        Debug.Log("Message 3");
    }

    public void LoadAsync()
    {
        
        Debug.Log("red ");
        //MyAsyncInt();//no hay error
        MyAsyncMethod(); 
        MyAsyncMethod1();
        MyAsyncMethod2();
   
    }
    IEnumerator CoroutineMethod()
    {
        Debug.Log("Message 2");
        yield return new WaitForEndOfFrame();
        Debug.Log("Message 4");
    }

    private async void MyAsyncMethod()
    {
       
       // Debug.Log("Waiting 1 second");
        await Task.Delay(TimeSpan.FromSeconds(1));
        var number = await MyAsyncInt();
        Debug.Log("red " + number);
        //Debug.Log("RUN");
    }
    private async void MyAsyncMethod1()
    {

        // Debug.Log("Waiting 1 second");
        await Task.Delay(TimeSpan.FromSeconds(2));
        var number = await MyAsyncInt();
        Debug.Log("red 2");
        //Debug.Log("RUN");
    }
    private async void MyAsyncMethod2()
    {

        // Debug.Log("Waiting 1 second");
        await Task.Delay(TimeSpan.FromSeconds(3));
        var number = await MyAsyncInt();
        Debug.Log("Green");
        Debug.Log("RUN");
    }
    private async Task<int> MyAsyncInt()
    {
       
        for (int i=0; i<100;i++)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1));
        }
        return 1;
    }
}
