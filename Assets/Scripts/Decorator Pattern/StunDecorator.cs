using UnityEngine;

public class StunDecorator : SwordDecorator
{
    public StunDecorator(ISword sword) : base(sword)
    {

    }

    public override void SkillDetails()
    {
        base.Sword.AddPrice(55);
        base.Sword.AddDescription("Can stun enemy");
        base.Sword.SkillDetails();
    }
}
