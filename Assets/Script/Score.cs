using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  
    void Start()
    {
        Text scoreLabel = GameObject.Find("Score").GetComponent<Text>();
        scoreLabel.color = Color.red;

        int Score = ResultMgr.GetScoreData();
        scoreLabel.text = Score.ToString() + "点";
    }

}
