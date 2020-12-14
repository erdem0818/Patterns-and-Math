using UnityEngine;

// attached to the player
public class MoveObject : MonoBehaviour
{
    private const float step_distance = 1f;

    public void MoveForward()
    {
        Move(Vector3.up);
    }

    public void MoveRight()
    {
        Move(Vector3.right);
    }

    public void MoveLeft()
    {
        Move(Vector3.left);
    }

    public void MoveBack()
    {
        Move(Vector3.down);
    }

    private void Move(Vector3 dir)
    {
        transform.Translate(dir * step_distance);
    }
}
