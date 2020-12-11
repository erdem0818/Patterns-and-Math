using UnityEngine;
public class HealerHandler<T> : AbstractHandler<T> where T : HandleData
{
    public override string Handle(T request)
    {
        
        if (request.requestObject.Equals("Heal Potion"))
            return $"I'll give you a {request.requestObject}.\n";
        else
        {
            //Debug.Log($"I do not have {request.requestObject} to give you");
            return base.Handle(request);
        }

    }
    //public override object Handle(object request)
    //{
    //    if((request as string) == "Heal Potion") return $"I'll give you a {request.ToString()}.\n";
    //    else return base.Handle(request);
    //}
}
