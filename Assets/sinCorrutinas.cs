using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sinCorrutinas : MonoBehaviour
{
    public Image img;
    public Image img2;
    public Image img3;
    float cont = 0;
    bool tim = false;
    void Start()
    {
        
    }
   public void timerSemaforo()
    {

        tim = true;
      
    }
  
    void Update()
    {
        if (tim)
        {
            cont += Time.deltaTime;
        }

        if (cont > 1.0)
        {
            img.color = new Color32(255, 0, 0, 255);
        }

        if (cont > 2.0)
        {
            img2.color = new Color32(255, 0, 0, 255);
        }
        if (cont > 3.0)
        {
            img3.color = new Color32(255, 0, 0, 255);
        }
        if (cont > 4.0)
        {
            img.color = new Color32(0, 255, 0, 255);
            img2.color = new Color32(0, 255, 0, 255);
            img3.color = new Color32(0, 255, 0, 255);
        }
       
    }
}
