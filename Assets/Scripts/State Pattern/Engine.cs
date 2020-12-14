using System;

public class Engine 
{
    public int EngineLevel { get; set; }

    private EngineState _state;
    public EngineState State
    {
        get
        {
            return _state;
        }
        set
        {
            _state = value;
            //whenever state has changed
            _state.HandleState(this);
        }
    }

    public Engine()
    {
        this.EngineLevel = 50;
        ControlEngineHeatLevel();
    }

    private void ControlEngineHeatLevel()
    {
        if (this.EngineLevel > 80)
            this.State = new OverloadState();
        else
            this.State = new OkState();
    }

    public void BreakPedal(int engineHeat)
    {
        this.EngineLevel -= engineHeat;
    }

    public void Throttle(int engineHeat)
    {
        this.EngineLevel += engineHeat;
        ControlEngineHeatLevel();
    }
}
