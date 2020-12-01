using UnityEngine;

public class NPCHammerSmith : NPC
{
    protected override void PlayAnimation()
    {
        Debug.Log("HammerSmith animation played");
    }
    protected override void Speak()
    {
        Debug.Log("Welcome to HammerSmith, give me your sword and let me do it stronger");
    }
    protected override void GiveMission()
    {
        //stupid npc mission
        Debug.Log("but you have to give me wolf tail");
    }

    //*******
    protected override void Shout()
    {
        Debug.Log("NOW YOU CAN DEFEAT MONSTERS WITH THIS SWORD");
    }
}
