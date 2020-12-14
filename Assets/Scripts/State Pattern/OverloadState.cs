using UnityEngine;
public class OverloadState : EngineState
{
    public override void HandleState(Engine engine)
    {
        Debug.Log($"Engine heat level is: {engine.EngineLevel}. Engine state is overload. Need to break.");

        engine.BreakPedal(20);

        if (engine.EngineLevel > 80)
            engine.State = new OverloadState();
        else
            engine.State = new OkState();
    }
}
