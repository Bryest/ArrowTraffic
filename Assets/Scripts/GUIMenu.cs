using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIMenu : MonoBehaviour
{
    public TMP_Text score;

    public void Start()
    {
        GameManager._instance.ReplaceWithTheHighestScore();

        score.text = GameManager._instance.higherScore.ToString() ;

    }

    public void PlayButton()
    {
        GameManager._instance.GameScene();
    }
}
