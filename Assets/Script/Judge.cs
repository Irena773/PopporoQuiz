using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Judge : MonoBehaviour
{

    public void JudgeAnswer()
    {
        GameObject director = GameObject.Find("GameDirector");

        QuizMgr quizMgr = director.GetComponent<QuizMgr>();
        string answerText = quizMgr.answer;

        Text selectedBtn = this.GetComponentInChildren<Text>();

        if(selectedBtn.text == answerText)
        {
            Debug.Log("正解");
            ResultMgr.SetJudgeData("正解");
            SceneManager.LoadScene("Result");
        }
        else
        {
            Debug.Log("不正解");
            ResultMgr.SetJudgeData("不正解");
            SceneManager.LoadScene("Result");
        }
    }
    
}
