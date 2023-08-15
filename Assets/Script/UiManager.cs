using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    int score = 0;
    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void incrementScore()
    {
        score++;
        scoreText.text = "Score : " + score;
    }
}
