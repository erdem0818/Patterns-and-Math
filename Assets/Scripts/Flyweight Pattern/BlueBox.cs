using UnityEngine;

public class BlueBox : Box
{
    public BlueBox(int _width, int _height,GameObject _sprite)
    {
        this.width = _width;
        this.height = _height;
        this.boxColor = BoxColor.blue;
        this.sprite = _sprite;
    }

    public override void Draw(string a)
    {
        Debug.Log($"{boxColor} box drawn. {this.width},{this.height}");
        Debug.Log(a);
    }
}
