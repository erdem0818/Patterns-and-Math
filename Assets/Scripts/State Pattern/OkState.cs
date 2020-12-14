using UnityEngine;
public class OkState : EngineState
{
    public override void HandleState(Engine engine)
    {
        Debug.Log($"Engine heat level is: {engine.EngineLevel}. Engine Heat level is ok.");
    }
}

