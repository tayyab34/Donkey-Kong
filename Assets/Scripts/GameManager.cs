using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI Lives;
    public TextMeshProUGUI HighestScore;
    // Start is called before the first frame update
    void Start()
    {
        AddLives(0);
        AddScore(score);
        HighestScore.text = "HighestScore: " +0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Lives Calculation
    private void AddLives(int livestoadd)
    {
        lives += livestoadd;
        Lives.text="Lives: " + lives;
        Debug.Log("Lives:" + lives);
        if (lives == 0)
        {
            Destroy(gameObject);
        }
    }
    //Score Calculation
    private void AddScore(int scoretoadd)
    {
        score += scoretoadd;
        Score.text = "Score: " + score;
        Debug.Log("Score:" + score);
    }
}
