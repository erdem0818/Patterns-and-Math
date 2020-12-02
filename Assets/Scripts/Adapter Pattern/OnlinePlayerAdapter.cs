using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlinePlayerAdapter : OnlinePlayer, IOnlinePlayerData
{
    public string FullName()
    {
        return FirstName() + " " + LastName();
    }

    public string LocationAndServer()
    {
        return Location() + " " + Server();
    }
}
