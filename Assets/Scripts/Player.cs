using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody mR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mR = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        mR.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
