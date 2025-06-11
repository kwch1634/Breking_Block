using UnityEngine;

class Blocks_1 : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Game_Manager_01").GetComponent<Game_Manager_01>().OnBlockDestroyed();
        Destroy(gameObject);
    }

}
