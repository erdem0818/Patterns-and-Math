using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerOfObjects : MonoBehaviour
{
    public static float predictedTime;

    public MotorOfObjects objectA;
    public MotorOfObjects objectB;

    public float timeStep = 0.02f;

    private void Start()
    {
        Time.fixedDeltaTime = timeStep;
        float h = objectA.transform.position.x - objectB.transform.position.x;

        float a = objectB.acceleration - objectA.acceleration; //ivme
        float b = 2*(objectB.initialVelocity  - objectA.initialVelocity); //başlangıç hızları

        float c = -2*h;

        predictedTime = (-b + Mathf.Sqrt(b*b - 4* a *c)) / (2 *a); //kök bulma formülü
        Debug.Log(predictedTime);
    }
}
