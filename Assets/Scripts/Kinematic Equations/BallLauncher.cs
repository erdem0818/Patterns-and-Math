using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] private Rigidbody ball;
    [SerializeField] private Transform target;

    [SerializeField] private float h = 25;
    [SerializeField] private float gravity = -18;

    [SerializeField] private bool debugPath;

    private void Start()
    {
        ball.useGravity = false;  
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
        
        if (debugPath)
            DrawPath();
    }

    private void Launch()
    {
        Physics.gravity = Vector3.up * gravity;
        ball.useGravity = true;
        ball.velocity = CalculateLaunchData().initialVelocity;
    }
    LaunchData CalculateLaunchData()
    {
        //Y'de ki fark Py
        float displacementY = target.position.y - ball.position.y;
        //X ve Z deki fark vektörü Px
        Vector3 displacementXZ = new Vector3(target.position.x - ball.position.x, 0, target.position.z - ball.position.z);

        float time = (Mathf.Sqrt((-2 * h) / gravity) + Mathf.Sqrt((2 * (displacementY - h)) / gravity));

        //kök içinde -2gh
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * h);
        // Px / (kök içinde -2h/g) + kök içinde(2 * (Py - h) / g)
        Vector3 velocityXZ = displacementXZ / time;

        return new LaunchData(velocityXZ + velocityY * -Mathf.Sign(gravity), time);
    }

    private void DrawPath()
    {
        LaunchData launchData = CalculateLaunchData();
        Vector3 previousDrawPoint = ball.position;

        int resulation = 30;
        for(int i=0; i <= resulation; i++)
        {
            float simulationTime = i / (float)resulation * launchData.timeToTarget;
            Vector3 displacement = launchData.initialVelocity * simulationTime + Vector3.up * gravity * simulationTime * simulationTime / 2f;
            Vector3 drawPoint = ball.position + displacement;
            Debug.DrawLine(previousDrawPoint, drawPoint, Color.green);
            previousDrawPoint = drawPoint;
        }
    }

    struct LaunchData
    {
        public readonly Vector3 initialVelocity;
        public readonly float timeToTarget;

        public LaunchData(Vector3 initialVelocity, float timeToTarget)
        {
            this.initialVelocity = initialVelocity;
            this.timeToTarget = timeToTarget;
        }
    }
}
