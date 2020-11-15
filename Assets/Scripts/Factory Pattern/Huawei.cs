using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huawei : IPhone
{
    private PhoneType _phoneType=PhoneType.Huawei;

    public void GetHardwares()
    {
        Debug.Log("Huawei");
    }
}
