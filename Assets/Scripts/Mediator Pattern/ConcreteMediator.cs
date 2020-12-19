using UnityEngine;
public class ConcreteMediator : IMediator
{
    private Component1 _component1;
    private Component2 _component2;

    public ConcreteMediator(Component1 c1, Component2 c2)
    {
        this._component1 = c1;
        this._component1.SetMeditaor(this);
        this._component2 = c2;
        this._component2.SetMeditaor(this);
    }

    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Debug.Log("Mediator reacts on A and triggers folowing operations:");
            this._component2.DoC();
        }
        if (ev == "D")
        {
            Debug.Log("Mediator reacts on D and triggers following operations:");
            this._component1.DoB();
            this._component2.DoC();
        }
    }
}