using UnityEngine;

public class ExecutorFly : MonoBehaviour
{
    public GameObject blackSprite;
    public GameObject blueSprite;

    private void Start()
    {
        BoxFactory factory = new BoxFactory();

        Box blackBox1 = factory.getBox(BoxColor.black,10,10,blackSprite);
        Box blueBox1 = factory.getBox(BoxColor.blue,20,20,blueSprite);
        Box blackBox2 = factory.getBox(BoxColor.black,11,11,blackSprite);
        Box blackBox3 = factory.getBox(BoxColor.black,12,12,blackSprite);
        Box blueBox2 = factory.getBox(BoxColor.blue,21,21,blueSprite);

        blackBox1.Draw("bir");
        blueBox1.Draw("iki");
        blackBox2.Draw("üç");
        blackBox3.Draw("dört");
        blueBox2.Draw("beş");
    }
}
