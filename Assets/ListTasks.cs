using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ListTasks : MonoBehaviour
{

    void Update()
    {
        foreach (Tareas.Tarea item in Tareas.listTasks)
        {
            if (Time.time > item.startMoment)
            {
                item.action();
                Tareas.listTasks.Remove(item);
                break;
            }

        }
    }

    public static void test() {
        print("test");
    }
}

public static class Tareas
{
    public class Tarea
    {
        public float startMoment;
        public Action action;
    }

    public static List<Tarea> listTasks = new List<Tarea>();
    public static void New(float time, Action action)
    {
        Tarea task = new Tarea
        {
            startMoment = Time.time + time,
            action = action
        };
        listTasks.Add(task);
    }
}
