using UnityEngine;

public class NPCShop : NPC
{
    protected override void PlayAnimation()
    {
        Debug.Log("Shopper animation played");
    }
    protected override void Speak()
    {
        Debug.Log("What do you want from this shop?");
    }
    protected override void GiveMission()
    {
        //stupid npc mission
        Debug.Log("Can you bring me some dog teeth?");
    }
}
