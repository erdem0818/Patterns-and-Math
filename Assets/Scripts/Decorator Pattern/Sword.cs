using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SwordTypes
{
    Fire,Ice,Iron
}
public class Sword : ISword
{
    private SwordTypes swordType;
    private string _description;
    private int _level;
    private int _price;

    public Sword(SwordTypes type,string desc, int level, int price)
    {
        swordType = type;
        _description = desc;
        _level = level;
        _price = price;
    }

    public void SkillDetails()
    {
        Debug.Log(_description);
    }

    public void AddPrice(int addedPrice)
    {
        _price += addedPrice;
    }
    public void AddDescription(string addedDescription)
    {
        _description = "Type: " + swordType.ToString() + "Level: " + _level.ToString() + "Price: " + _price.ToString() + addedDescription;
    }

}
