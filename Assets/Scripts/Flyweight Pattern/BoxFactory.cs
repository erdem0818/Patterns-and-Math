using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFactory
{
   public Dictionary<BoxColor,Box> boxes;

   public BoxFactory()
   {
       boxes = new Dictionary<BoxColor, Box>();
   }

    public Box getBox(BoxColor color,int width,int height,GameObject sprite)
    {
        if(boxes.ContainsKey(color)) return boxes[color];

        Box box =null;

        if(color.Equals(BoxColor.black)) 
        {
            box = new BlackBox(width,height,sprite);
            Debug.Log(boxes.Count);
        }
        else if(color.Equals(BoxColor.blue)) 
        {
            box = new BlueBox(width,height,sprite);
            Debug.Log(boxes.Count);
        }

        boxes.Add(color,box);
        return box;
    }

}
