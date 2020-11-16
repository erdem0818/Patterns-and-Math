using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorOfObjects : MonoBehaviour
{
    public float initialVelocity;
    private float currentVelocity;
    public float acceleration;

    private void Start()
    {
        currentVelocity = initialVelocity;
    }

    private void FixedUpdate()
    {
        if(Time.fixedTime < TimerOfObjects.predictedTime)
        {
            currentVelocity += acceleration * Time.fixedDeltaTime;
            transform.Translate(Vector3.right * currentVelocity * Time.fixedDeltaTime);
        }
    }
}
