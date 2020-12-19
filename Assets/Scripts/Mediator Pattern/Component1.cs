using UnityEngine;
public class Component1 : BaseComponent
{
    public void DoA()
    {
        Debug.Log("Component 1 does A.");

        this._mediator.Notify(this, "A");
    }

    public void DoB()
    {
        Debug.Log("Component 1 does B.");

        this._mediator.Notify(this, "B");
    }
}
