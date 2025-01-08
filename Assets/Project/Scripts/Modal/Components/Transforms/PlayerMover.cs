using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private Rigidbody rb;
    public static PlayerMover instance;
    private Vector3 forceDirection;
    public void PlayerMovement(Vector2 directions)
    {
        ChangeDirection(directions);
        ChangeSpeed();
    }
    private void ChangeDirection(Vector2 directions)
    {
        forceDirection += directions.x * moveSpeed * transform.right;
        forceDirection += directions.y * moveSpeed * transform.forward;
        rb.AddForce(forceDirection, ForceMode.Impulse);
        forceDirection = Vector3.zero;
    }
    private void ChangeSpeed()
    {
        Vector3 horizontalVel = rb.linearVelocity;
        horizontalVel.y = Values.NeutralFloatValue;
        if (horizontalVel.sqrMagnitude > maxSpeed * maxSpeed)
            rb.linearVelocity = horizontalVel.normalized * maxSpeed + Vector3.up * rb.linearVelocity.y;
        else
            rb.linearVelocity = Vector3.zero;
    }
    private void Start() => instance = this;
}
