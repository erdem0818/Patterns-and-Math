using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorPlayer : MonoBehaviour
{
    private void Start() 
    {
        Sword sword = new Sword(SwordTypes.Iron,"basic sword",22,80);
        sword.SkillDetails();

        StunDecorator stun = new StunDecorator(sword);
        stun.SkillDetails();
        
        FireDecorator fire = new FireDecorator(stun);
        fire.SkillDetails();
    }
}
