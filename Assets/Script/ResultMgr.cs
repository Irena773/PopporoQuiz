using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultMgr : MonoBehaviour
{

    public static string g_judgeData;
    public static int g_scoreData;
    public Image image;
    private Sprite loadingImage;
    void Start()
    {

        if(g_judgeData == "不正解")
        {
            
            loadingImage = Resources.Load<Sprite>("batsu");
            image = this.GetComponent<Image>();
            //画像を置換
            image.sprite = loadingImage;

            Text judgeLabel = GameObject.Find("JudgeLabel").GetComponent<Text>();
            judgeLabel.text = "不正解";
        }else if(g_judgeData == "正解")
        {
            g_scoreData++;
        }
    }

    public static void SetJudgeData(string judgeData)
    {
        g_judgeData = judgeData;
    }

    public static int SetScoreData(int scoreData)
    {
        g_scoreData = scoreData;
        return g_scoreData;
    }

    public static int GetScoreData()
    {
        return g_scoreData;
    }
}
