using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeClient : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = new Player();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SaveManager.getInstance.SaveGame(_player);
        }
    }
}
