using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : IOrder
{
    private Dictionary<string, Item> items;

    public Shop()
    {
        items = new Dictionary<string, Item>();

        Item sword = new Item("Sword");
        Item axe = new Item("Axe");
        Item shield = new Item("Shield");

        items.Add(sword.itemName, sword);
        items.Add(axe.itemName, axe);
        items.Add(shield.itemName, shield);
    }

    public Item getItem(string itemName)
    {
        if(items.ContainsKey(itemName))
            return items[itemName];
        else 
            return null;
    }
}
