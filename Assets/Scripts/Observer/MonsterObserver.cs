using UnityEngine;

public class MonsterObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if((subject as ObserverPlayer).state == States.attack)
        {
            Debug.Log("Monster can attack to the player");
        }
    }
}
