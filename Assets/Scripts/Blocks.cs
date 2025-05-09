using UnityEngine;

class Blocks : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
