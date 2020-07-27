using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverImg;
    public static bool gameOver = false;

    public void GameOver()
    {
        // Debug.Log("in GameUI");
        gameOverImg.SetActive(true);
        gameOver = true;

    }
    public void OnOkButtonPressed ()
    {
        gameOver = false;
        SceneManager.LoadScene("SampleScene");

    }
    public void OnPlayButtonPressed()
    {
        
        SceneManager.LoadScene("SampleScene");

    }

}
