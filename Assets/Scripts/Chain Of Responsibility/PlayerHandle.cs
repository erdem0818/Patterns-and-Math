using System.Collections.Generic;
using UnityEngine;

class PlayerHandle
{
    public static void SendRequest(AbstractHandler abstractHandler)
    {
        foreach(var obj in new List<string> {"Horse", "Sword","Mana Potion"})
        {
            Debug.Log($"Player: I want to {obj} !");
            
            var result = abstractHandler.Handle(obj);

            if(result != null) Debug.Log($"    {result}");
            else Debug.Log($"I do not have {obj} to give you");
        }
    }
}
