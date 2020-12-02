using UnityEngine;

public class SwordDecorator : ISword
{
    internal ISword Sword;

    public SwordDecorator(ISword sword)
    {
        Sword = sword;
    }
    public virtual void SkillDetails()
    {
        Sword.SkillDetails();
    }

    public virtual void AddPrice(int addedPrice)
    {
        Sword.AddPrice(addedPrice);
    }
    public virtual void AddDescription(string addedDescription)
    {
        Sword.AddDescription(addedDescription);
    }
}
