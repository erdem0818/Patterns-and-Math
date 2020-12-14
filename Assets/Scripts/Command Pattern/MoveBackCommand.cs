public class MoveBackCommand : Command
{
    private MoveObject _moveObject;

    public MoveBackCommand(MoveObject moveObject)
    {
        this._moveObject = moveObject;
    }
    public override void Execute()
    {
        _moveObject.MoveBack();
    }

    public override void Undo()
    {
        _moveObject.MoveForward();
    }
}
