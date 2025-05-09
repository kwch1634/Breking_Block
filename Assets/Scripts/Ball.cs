using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody mR;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mR = GetComponent<Rigidbody>();
        mR.linearVelocity = new Vector3(speed,speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
