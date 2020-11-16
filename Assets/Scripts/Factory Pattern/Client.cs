using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    PhoneStore store;
    
    private void  Start()
    {
       store = new PhoneStore(new PhoneFactory()); 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            store.orderPhone(PhoneType.Samsung);
        }    
        else if(Input.GetKeyDown(KeyCode.W))
        {
            store.orderPhone(PhoneType.Huawei);
        }

    }
}
