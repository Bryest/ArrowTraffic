using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public TMP_Text score;
    private void Start()
    {
        score.text = "Score 0";
        GameManager._instance.InitializeScoreInGame();
    }

    private void Update()
    {
        score.text = "Score " + GameManager._instance.CountScoreInGame().ToString();
    }
}
