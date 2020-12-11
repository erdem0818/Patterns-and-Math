public abstract class AbstractHandler<T> : IHandler<T> where T : HandleData
{
    private IHandler<T> _nextHandler;


    public IHandler<T> SetNext(IHandler<T> handler)
    {
        this._nextHandler = handler;
        //Class.SetNext(class).SetNext(class); IHandler func.
        return handler;
    }
    public virtual string Handle(T request)
    {
        if(this._nextHandler != null) return this._nextHandler.Handle(request);
        else return null;
    }

    //public virtual object Handle(object request)
    //{
    //    if (this._nextHandler != null) return this._nextHandler.Handle(request);
    //    else return null;
    //}
}
