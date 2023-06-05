using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject button;
    public GameObject getReady;
    public GameObject gameOver;
    private int score;
    Vector3 originalPos;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        originalPos = player.transform.position;
        GameStart();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        button.SetActive(false);
        gameOver.SetActive(false);
        getReady.SetActive(false);
        
        Time.timeScale = 1f;
        player.enabled = true;

        player.transform.position = originalPos;

        Pipes_Movement[] pipes = FindObjectsOfType<Pipes_Movement>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameStart()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        getReady.SetActive(true);
        gameOver.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        Debug.Log("PAUSE");
    }



    public void GameOver()
    {
        gameOver.SetActive(true);
        button.SetActive(true);

        Pause();
    }

    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
    }

    
}
