using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour, IMenuComponent
{
    private string _name; 
    private List<IMenuComponent> _menus;

<<<<<<< HEAD
    private void Awake()
=======
    public Awake()
>>>>>>> f46c4ad623bca470ae1010096f34f214530322c2
    {
        this._name = gameObject.name;
        _menus =new List<IMenuComponent>();
    }
<<<<<<< HEAD
=======
    
>>>>>>> f46c4ad623bca470ae1010096f34f214530322c2
    public void Add(IMenuComponent menu)
    {
        _menus.Add(menu);
    }

    public void Remove(IMenuComponent menu)
    {
        _menus.Remove(menu);
    }

    public void OpenMenuBar()
    {
        Debug.Log(_name);
        foreach(IMenuComponent e in _menus)
        {
            e.OpenMenuBar();
        }
    }

    public void CloseMenuBar()
    {
        Debug.Log(_name);
        foreach(IMenuComponent e in _menus)
        {
            e.CloseMenuBar();
        }
    }
}
