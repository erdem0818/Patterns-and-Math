using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverExecutor : MonoBehaviour
{
    ObserverPlayer subject;

    private void Start()
    {
        subject = new ObserverPlayer();

        var observerMonster = new MonsterObserver();
        var observerShaman = new ShamanObserver();

        subject.Attach(observerMonster);
        subject.Attach(observerShaman);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            subject.ChangeState();
        }
    }
}
