using UnityEngine;

public class MiniMove : MonoBehaviour
{
    public float bounceForce = 15f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating(nameof(Bounce), 1f, 1f); // bounce every second
    }

    void Bounce()
    {
        rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}
