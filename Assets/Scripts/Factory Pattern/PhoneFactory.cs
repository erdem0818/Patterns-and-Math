using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneFactory : MonoBehaviour
{
    public IPhone CreatePhone(PhoneType type)
    {
        IPhone phone = null;

        if(type == PhoneType.Samsung)
        {
            phone = new Samsung();
            return phone;
        }
        else if(type == PhoneType.Huawei)
        {
            phone = new Huawei();
            return phone;
        }

        return null;
    }
}
