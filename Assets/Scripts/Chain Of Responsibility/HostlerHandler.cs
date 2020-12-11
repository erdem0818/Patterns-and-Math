using UnityEngine;
public class HostlerHandler<T> : AbstractHandler<T> where T : HandleData
{
    public override string Handle(T request)
    {
        if (request.requestObject.Equals("Horse"))
            return $"I'll give you a {request.requestObject}.\n";
        else
        {
            //Debug.Log($"I do not have {request.requestObject} to give you");
            return base.Handle(request);
        }
    }
}
