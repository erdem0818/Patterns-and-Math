public class MoveForwardCommand : Command
{
    private MoveObject _moveObject;

    public MoveForwardCommand(MoveObject moveObject)
    {
        this._moveObject = moveObject;
    }

    public override void Execute()
    {
        _moveObject.MoveForward();
    }

    public override void Undo()
    {
        _moveObject.MoveBack();
    }
}
