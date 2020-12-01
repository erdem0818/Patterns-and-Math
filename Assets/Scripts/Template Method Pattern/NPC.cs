using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC
{
    public void TemplateMethod()
    {
        PlayParticles();
        PlayAnimation();
        Speak();
        GiveMission();
        Shout();
    }

    //this method already have an implementation.
    protected void PlayParticles()
    {
        Debug.Log("Player interacts with NPC");
    }

    //abstract methods must be implemented.
    protected abstract void PlayAnimation();
    protected abstract void Speak();
    protected abstract void GiveMission();

    //you may override this method if you want. 
    protected virtual void Shout() {}
}
