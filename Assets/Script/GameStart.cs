using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public static int qCount;
    public void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            SceneManager.LoadScene("Quiz");
        }
    }

    public void NextQuiz()
    {
        if (SceneManager.GetActiveScene().name == "Result")
        {
            if(qCount < 5)
            {
                qCount++;
                SceneManager.LoadScene("Quiz");
            }
            else
            {
                qCount = 0;
                SceneManager.LoadScene("Score");

            }
        }
    }

    public void BackToTitle()
    {
        if(SceneManager.GetActiveScene().name == "Score")
        {
            ResultMgr.SetScoreData(0);
            SceneManager.LoadScene("Title");

        }
    }
}
