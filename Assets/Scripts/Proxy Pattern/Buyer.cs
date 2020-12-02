using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buyer : MonoBehaviour, IOrder
{
    private Shop shop = new Shop();

    private List<Shop> shops = new List<Shop>();

    private void Start()
    {
        shops.Add(shop);// it will check this shop pnly because shops list contains 1 shop

        getItem("Sword"); // this will give a sword;
        getItem("Gun"); //this will give nothing, because gun is not exist in shop
    }
    public Item getItem(string itemName)
    {
        foreach(Shop e in shops)
        {
            Item item = e.getItem(itemName);
            if(item!= null)
                Debug.Log(item.itemName);
            return item;     
        }
        return null;
    }
}
