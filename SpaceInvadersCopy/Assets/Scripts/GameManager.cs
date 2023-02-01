using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public int newScore;
    private float scoreSpeed = 0.001f;
    private float nextScore = 0.0f;
    public bool gameOver = false;

    [SerializeField] private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Score is: " + newScore);
        if(newScore != score && Time.time > nextScore)
        {
            nextScore = Time.time + scoreSpeed;
            UpdateScore();
            scoreText.text = "Score: " + newScore.ToString();
        }

        if (gameOver == true)
        {
            Debug.Log("GameOver!");
        }
    }
    
    public void UpdateScore()
    {
        if (newScore != score && score > newScore)
        {
            newScore += 1;
        }
    }

}
