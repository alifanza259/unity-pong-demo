using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;

    void Update()
    {
        if (scorePlayer1 >= goalToWin || scorePlayer2 >= goalToWin)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void FixedUpdate()
    {
        Text uiScoreTextPlayer1 = scoreTextPlayer1.GetComponent<Text>();
        uiScoreTextPlayer1.text = scorePlayer1.ToString();

        Text uiScoreTextPlayer2 = scoreTextPlayer2.GetComponent<Text>();
        uiScoreTextPlayer2.text = scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        scorePlayer2++;
    }
}
