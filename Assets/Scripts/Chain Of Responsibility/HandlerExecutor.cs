using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerExecutor : MonoBehaviour
{
    private void Start()
    {
        var HostlerHandler = new HostlerHandler();
        var SwordMasterHandler = new SwordMasterHandler();
        var HealerHandler = new HealerHandler();

        HostlerHandler.SetNext(SwordMasterHandler).SetNext(HealerHandler);

        PlayerHandle.SendRequest(HostlerHandler);
    }
}
