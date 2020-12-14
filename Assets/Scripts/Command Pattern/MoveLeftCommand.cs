public class MoveLeftCommand : Command
{
    private MoveObject _moveObject;

    public MoveLeftCommand(MoveObject moveObject)
    {
        this._moveObject = moveObject;
    }

    public override void Execute()
    {
        _moveObject.MoveLeft();
    }

    //undo is opposite the execute method
    public override void Undo()
    {
        _moveObject.MoveRight();
    }
}
