using UnityEngine;

public class SubMenu : IMenuComponent
{
    private string _name;

    public SubMenu(string name)
    {
        this._name = name;
    }
    public void OpenMenuBar()
    {
        Debug.Log(_name);
    }

    public void CloseMenuBar()
    {
        Debug.Log(_name);
    }
}