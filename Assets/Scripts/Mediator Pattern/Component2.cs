using UnityEngine;
public class Component2 : BaseComponent
{
    public void DoC()
    {
        Debug.Log("Component 2 does C.");

        this._mediator.Notify(this, "C");
    }

    public void DoD()
    {
        Debug.Log("Component 2 does D.");

        this._mediator.Notify(this, "D");
    }
}
