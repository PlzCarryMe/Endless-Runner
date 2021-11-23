using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int currentScore = 0;
    private int lastScoreHighlight = 0;

    [Header("Score Highlight")]
    public int scoreHighlightRange;
    public CharacterSoundController sound;

    // Start is called before the first frame update
    void Start()
    {
        // reset
        currentScore = 0;
        lastScoreHighlight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetCurrentScore()
    {
        return currentScore;
    }

    public void FinishScoring()
    {
        // set high score
        if (currentScore > ScoreData.highScore)
        {
            ScoreData.highScore = currentScore;
        }
    }

    public void IncreaseCurrentScore(int increment)
    {
        currentScore += increment;

        if (currentScore - lastScoreHighlight > scoreHighlightRange)
        {
            sound.PlayScoreHighlight();
            lastScoreHighlight += scoreHighlightRange;
        }
    }
}
