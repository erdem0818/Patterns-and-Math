public interface IHandler<T> where T : HandleData
{
    IHandler<T> SetNext(IHandler<T> handler);
    string Handle(T request);
}

