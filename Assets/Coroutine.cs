using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine : MonoBehaviour
{
    Coroutine routine;
    void Start()
    {
        StartCoroutine(CoroutineMethod("1", 2, 3f));
    }

    IEnumerator CoroutineMethod(string arg1, int arg2, float arg3)
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
        }
    }

    #region
    public void LoadCoroutine1()
    {
        StartCoroutine(CoroutineMethod2(1f, RedLigth));
       // StartCoroutine(CoroutineMethod2(1.2f, WhiteLigth));
       // StartCoroutine(CoroutineMethod2(2f, RedLigth));
       // StartCoroutine(CoroutineMethod2(2.2f, WhiteLigth));
      //  StartCoroutine(CoroutineMethod2(3f, RedLigth));
       // StartCoroutine(CoroutineMethod2(3.2f, WhiteLigth));
        StartCoroutine(CoroutineMethod2(4f, GreenLigth));
    }
    public void LoadCoroutine1s()
    {
        StartCoroutine(CoroutineMethod2(2f, RedLigth2));   
        StartCoroutine(CoroutineMethod2(4f, GreenLigth));
    }
    public void LoadCoroutine1ss()
    {
       
        StartCoroutine(CoroutineMethod2(3f, RedLigth3));   
        StartCoroutine(CoroutineMethod2(4f, GreenLigth));
    }

    IEnumerator CoroutineMethod2(float time, Action action)
    {
       Debug.Log("Esperando a" + time.ToString());
       yield return new WaitForSecondsRealtime(time);
       Debug.Log("corre " + time.ToString());
        action();
    }
    #endregion

    #region
    public void LoadCoroutine2()
    {
        StartCoroutine(CoroutineMethod3(1f, RedLigth));
    }

    IEnumerator CoroutineMethod3(float time, Action action)
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(.2f);
            RedLigth();
            yield return new WaitForSeconds(.4f);
            
            RedLigth2();
            yield return new WaitForSeconds(.6f);
          
            RedLigth3();

        }
        yield return new WaitForSeconds(.1f);
        GreenLigth();
    }
    #endregion

    #region
    //without coroutines
    float momStart = float.MaxValue;
    float timeExplode = 5f;
    public Image img;
    public Image img2;
    public Image img3;
    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.X))
        {
            Tareas.New(1f, flashLight);
            Tareas.New(2f, flashLight);
            Tareas.New(3f, flashLight);
            Tareas.New(4f, GreenLigth);
        }

    }

    void flashLight() {
        RedLigth();
        Tareas.New(.2f, WhiteLigth);
    }
    #endregion
    void WhiteLigth()
    {
        //Debug.Log("Luz Blanca");
        img.color= new Color32(255, 255, 225, 255);
    }
    void RedLigth()
    {
       // Debug.Log("Luz Roja");
        img.color = new Color32(255, 0, 0, 255); 
       
    }
    void RedLigth2()
    {
       // Debug.Log("Luz Roja");      
        img2.color = new Color32(255, 0, 0, 255);
    }
    void RedLigth3()
    {
       // Debug.Log("Luz Roja");
        img3.color = new Color32(255, 0, 0, 255);
    }
    void GreenLigth()
    {
       // Debug.Log("Explota");
        img.color = new Color32(0, 255, 0, 255);
        img2.color = new Color32(0, 255, 0, 255);
        img3.color = new Color32(0, 255, 0, 255);

    }
}
