using UnityEngine;

public class Car : MonoBehaviour
{
    private void Start()
    {
        Engine engine = new Engine();

        engine.Throttle(25);
        engine.Throttle(25);
        engine.Throttle(25);
    }
}
