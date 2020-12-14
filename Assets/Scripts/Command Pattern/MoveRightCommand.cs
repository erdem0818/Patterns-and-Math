public class MoveRightCommand : Command
{
    private MoveObject _moveObject;

    public MoveRightCommand(MoveObject moveObject)
    {
        this._moveObject = moveObject;
    }

    public override void Execute()
    {
        _moveObject.MoveRight();
    }

    //undo is opposite the execute method
    public override void Undo()
    {
        _moveObject.MoveLeft();
    }
}
