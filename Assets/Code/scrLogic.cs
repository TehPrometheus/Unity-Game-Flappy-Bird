using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Tilemaps;
using System;


public class scrLogic : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText = null;
    public GameObject gameOverScreen = null;

    private void Start()
    {
        playerScore = 0;
        scoreText.text = playerScore.ToString();
    }
    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    { 
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver() 
    {
        gameOverScreen.SetActive(true);
    }
}
