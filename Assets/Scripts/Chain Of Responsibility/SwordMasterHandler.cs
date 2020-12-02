public class SwordMasterHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if((request as string)== "Sword") return $"I'll give you a {request.ToString()}.\n";
        else return base.Handle(request);
    }
}
