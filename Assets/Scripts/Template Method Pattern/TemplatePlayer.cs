using UnityEngine;

public class TemplatePlayer : MonoBehaviour
{
    NPC npcHammerSmith;
    NPC npcShop;

    private void Start()
    {
        npcHammerSmith = new NPCHammerSmith();
        npcShop = new NPCShop();
    }

   private void Update()
    {
       if(Input.GetKeyDown(KeyCode.H)) npcHammerSmith.TemplateMethod();
       else if(Input.GetKeyDown(KeyCode.S)) npcShop.TemplateMethod();
    }
}
