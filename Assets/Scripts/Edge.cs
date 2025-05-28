using UnityEngine;

public class Edge : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Edge"))
        {
            Vector3 lenearVelocity = rb.linearVelocity;

            float angleDeg = 45f;
            float angleRad = angleDeg * Mathf.Deg2Rad;

            float cos = Mathf.Cos(angleRad);
            float sin = Mathf.Sin(angleRad);

            Vector3 rotatedVelocity = new Vector2(
                lenearVelocity.x * cos - lenearVelocity.y * sin,
                lenearVelocity.x * sin + lenearVelocity.y * cos
            );

            rb.linearVelocity = rotatedVelocity;
        }
    }
}
