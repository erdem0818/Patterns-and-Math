using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneStore
{
    private PhoneFactory _factory;

    public PhoneStore(PhoneFactory factory)
    {
        this._factory = factory;
    }

    public IPhone orderPhone(PhoneType type)
    {
        IPhone phone = _factory.CreatePhone(type);

        phone.GetHardwares();

        return phone;
    }
}
