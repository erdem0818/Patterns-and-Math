public class HostlerHandler : AbstractHandler
{
   public override object Handle(object request)
   {
       if((request  as string)=="Horse") return $"I'll give you a {request.ToString()}.\n";
       else return base.Handle(request);
   }
}
