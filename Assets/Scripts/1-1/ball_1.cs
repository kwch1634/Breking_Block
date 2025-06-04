using UnityEngine;

public class ball_1 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(-speed, speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
