using System.Collections.Generic;
using UnityEngine;

class PlayerHandle
{
    //Player must only send request , it should not be responsible for returning "don't have". need to fix
    public static void SendRequest(AbstractHandler<HandleData> abstractHandler)
    {
        foreach(HandleData obj in new List<HandleData> { new HandleData("Horse"),new HandleData("Mana Potion"),new HandleData("Sword") })
        {
            Debug.Log($"Player: I want to a {obj.requestObject} !");

            var result = abstractHandler.Handle(obj);

            if (result != null)
                Debug.Log($"  {result}");
            else
                Debug.Log($"I do not have {obj.requestObject} to give you");
        }

        //foreach(var obj in new List<string> {"Horse", "Sword", "Mana Potion"})
        //{
        //    Debug.Log($"Player: I want to {obj} !");

        //    var result = abstractHandler.Handle(new HandleData(obj));

        //    if (result != null) Debug.Log($"    {result}");
        //    else Debug.Log($"I do not have {obj} to give you");
        //}
    }
}
