using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_Manager_01 : MonoBehaviour
{
    int blockCount;
    int blockDestroyedCount = 0;
    int jamaDestroyedCount = 0;
    int gameScore = 0;


    void Start()
    {
        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
        //jamaCount = GameObject.FindGameObjectsWithTag("Jama")
        Debug.Log(blockCount);
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

    public void OnjamaDestroyed()
    {
        jamaDestroyedCount++;
        gameScore += 100;
        Debug.Log(gameScore);
    }

    void ShowClearUI()
    {
        Time.timeScale = 0f; // Pause the game

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("1-1");
        }
    }
}
