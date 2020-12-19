using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShamanObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if((subject as ObserverPlayer).state == States.LowHP)
        {
            Debug.Log("I can heal you");
        }
    }
}
