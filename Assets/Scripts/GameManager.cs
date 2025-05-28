using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject clearUI;
    int blockCount;
    int blockDestroyedCount = 0;
    int gameScore;
    

    void Start()
    {
        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
        Debug.Log(blockCount);
        clearUI.SetActive(false);
    }

    void Update()
    {
        //Debug.Log(blockDestroyedCount);
    }

    public void OnBlockDestroyed()
    {
        blockDestroyedCount++;
        if (blockDestroyedCount >= blockCount)
        {
            Debug.Log("All blocks destroyed!\nscore:" + gameScore);
            ShowClearUI();
        }
    }

    void ShowClearUI()
    {
        clearUI.SetActive(true);
        Time.timeScale = 0f; // Pause the game

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }

    public void OnGameScore()
    {
        gameScore += 1000;
    }
}
