using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterClient : MonoBehaviour
{
    private IOnlinePlayerData playerData;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            playerData = new OnlinePlayerAdapter();

            string fullName = playerData.FullName();
            string locationAndServer = playerData.LocationAndServer();

            Debug.Log(fullName);
            Debug.Log(locationAndServer);
        }
    }
}
