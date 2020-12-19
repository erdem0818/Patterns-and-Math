using System.Collections.Generic;
using UnityEngine;

public enum States
{
    idle, attack, LowHP
}
public class ObserverPlayer : ISubject
{ 
    public States state { get; private set; } = States.idle;

    private List<IObserver> _obseervers = new List<IObserver>();

   
    public void Attach(IObserver observer)
    {
        Debug.Log("Subject: Attached an observer");
        this._obseervers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Debug.Log("Subject: Detached an observer");
        this._obseervers.Remove(observer);
    }
    public void Notify()
    {
        Debug.Log("Notifying Observers");

        for(int i =0; i < _obseervers.Count; i++)
        {
            _obseervers[i].Update(this);
        }
    }

    public void ChangeState()
    {
        Debug.Log("\nPlayer: I am doing something.");

        int p = Random.Range(0, 3); //0,1,2
        this.state = (States)p;

        Debug.Log($"Player: My State has changed to {this.state}");

        this.Notify();
    }
}
