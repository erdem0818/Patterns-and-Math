using UnityEngine;

public abstract class Box   
{
    public int width;
    public int height;
    public BoxColor boxColor;
    public GameObject sprite;

    public abstract void Draw(string a);
}
