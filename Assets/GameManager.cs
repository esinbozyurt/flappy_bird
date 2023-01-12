using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public GameObject startButton;
    public Player player;

    public TMP_Text gameOverCountdown;
    public float countTimer = 5;
    public int score = 0;
    public TMP_Text score_txt;


    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 1;
        score_txt.text = score.ToString();
    }

    public void increase_score(int x)
    {
        score += x;
        score_txt.text=score.ToString();
    }

    private void Update()
    {
        if (player.isDead)
        {
            gameOverCountdown.gameObject.SetActive(true);    
            countTimer -= Time.unscaledDeltaTime;
        }

        gameOverCountdown.text = "Restarting in " + (countTimer).ToString("0");

        if (countTimer < 0)
        {
            RestartGame();
        }
    }

    public void StartGame()
    {
        //startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }


    public void RestartGame()
    {
        EditorSceneManager.LoadScene(0);
    }
}

