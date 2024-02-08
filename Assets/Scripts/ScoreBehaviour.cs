using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class ScoreBehaviour: MonoBehaviour
{
    public int currentScore { get; set; }
    public int higherScore{ get; set; }
    public float timer { get; set; }

    public void InitializeScoreInGame()
    {
        currentScore = 0;
        timer = 0;
    }

    public int CountScoreInGame()
    {
        timer += Time.deltaTime * 2;
        currentScore = (int)timer;

        return currentScore;
    }

    public void ReplaceWithTheHighestScore()
    {
        if(currentScore >= higherScore)
        {
            higherScore = currentScore;
        }
    }
}
