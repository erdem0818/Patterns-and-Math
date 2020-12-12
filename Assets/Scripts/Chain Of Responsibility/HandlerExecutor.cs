using UnityEngine;

public class HandlerExecutor : MonoBehaviour
{
    private void Start()
    {
        var HostlerHandler = new HostlerHandler<HandleData>();
        var SwordMasterHandler = new SwordMasterHandler<HandleData>();
        var HealerHandler = new HealerHandler<HandleData>();

        HostlerHandler.SetNext(HealerHandler).SetNext(SwordMasterHandler);  

        PlayerHandle.SendRequest(HostlerHandler);
    }
}
