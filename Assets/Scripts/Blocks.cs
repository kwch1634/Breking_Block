using UnityEngine;

class Blocks : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().OnBlockDestroyed();
        particle.Play();
        Destroy(gameObject);
    }

}
