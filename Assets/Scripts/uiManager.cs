using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    bool gameOver;   
    public Text scoreText;
    int score;
    public GameObject PauseResumeButton;
    public GameObject PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        PauseResumeButton.SetActive(true);
        PlayButton.SetActive(false);
        gameOver = false;
        score = 0;
        InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text = "Score : " + score;
    }
    void scoreUpdate()
    {
        if (gameOver == false)
        {
            score++;
        }
    }
    public void CheckGameOver()
    {
        gameOver = true;
    }

    public void PauseResume()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Play()
    {
        SceneManager.LoadScene ("level1");
        PauseResume();
        PauseResumeButton.SetActive(true);
        PlayButton.SetActive(false);
    }
  
}
