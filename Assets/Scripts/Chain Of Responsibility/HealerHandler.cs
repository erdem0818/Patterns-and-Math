public class HealerHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if((request as string) == "Heal Potion") return $"I'll give you a {request.ToString()}.\n";
        else return base.Handle(request);
    }
}
