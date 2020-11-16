using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samsung :IPhone
{
    private PhoneType _phoneType= PhoneType.Samsung;

    public void GetHardwares()
    {
        Debug.Log("Samsung");
    }
}
