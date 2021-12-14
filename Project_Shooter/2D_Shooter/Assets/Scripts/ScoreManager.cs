using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        if (score == 10)
        {
            score = 0;
            scoreDisplay.text = score.ToString();
            SceneManager.LoadScene("WinScreen");
        }
    }
}
