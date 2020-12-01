using UnityEngine;

public class FireDecorator : SwordDecorator
{
    public FireDecorator(ISword sword): base(sword)
    {

    }

    public override void SkillDetails()
    {
        base.Sword.AddPrice(45);
        base.Sword.AddDescription("Can fire to enemy");
        base.Sword.SkillDetails();
    }
}
