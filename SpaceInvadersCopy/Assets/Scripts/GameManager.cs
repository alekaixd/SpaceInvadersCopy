using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateScore(int scoreToAdd)
    {
        int oldScore = Score;
        while (oldScore < oldScore + scoreToAdd)
        {
            Score++;
            StartCoroutine(ScoreCountCooldown(0.1f));
            Debug.Log(Score);
            //update score board
        }
    }

    private IEnumerator ScoreCountCooldown(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
