using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    [SerializeField]private float addSpeed = 1.0f;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed += addSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed -= addSpeed;
        }
    }
}
