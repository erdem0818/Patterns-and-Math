using UnityEngine;

public class BlackBox : Box
{
    public BlackBox(int _width, int _height,GameObject _sprite)
    {
        this.width = _width;
        this.height = _height;
        this.boxColor = BoxColor.black;
        this.sprite = _sprite;
    }

    public override void Draw(string a)
    {
        Debug.Log($"{boxColor} box drawn. {this.width},{this.height}");
        Debug.Log(a);
    }
}