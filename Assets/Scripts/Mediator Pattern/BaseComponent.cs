public class BaseComponent 
{
    protected IMediator _mediator;

    public BaseComponent(IMediator meditaor = null)
    {
        this._mediator = meditaor;
    }

    public void SetMeditaor(IMediator meditaor)
    {
        this._mediator = meditaor;
    }
}
