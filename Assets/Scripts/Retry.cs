using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Title");
        }
        else if (Input.GetMouseButton(0)){
            SceneManager.LoadScene("Title");
        }
    }
}
