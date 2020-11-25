using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class QuizMgr : MonoBehaviour
{
    TextAsset csvFile;
    private List<string[]> csvDatas = new List<string[]>();
   
    public int index;
    public int answerNumber;
    public string answer;

   
    void Start()
    {
        LoadCsv();
        QuestionLabelSet();
        AnswerLabelSet();
    }

    private void LoadCsv()
    {
        csvFile = Resources.Load("Quiz") as TextAsset;
        StringReader reader = new StringReader(csvFile.text);

        while(reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
        }
    }

       private void QuestionLabelSet()
    {
        //特定のオブジェクトを検索してアクセス
        Text qLabel = GameObject.Find("QLabel").GetComponent<Text>();
       
       index = Random.Range(1, csvDatas.Count)-1;

        //データをセットすることで既存情報を上書きできる
        qLabel.text = csvDatas[index][0];
        answerNumber = int.Parse(csvDatas[index][5]);
        answer = csvDatas[index][int.Parse(csvDatas[index][5])];
       
        Debug.Log("answernumber:" + answerNumber);
       
    }

    private void AnswerLabelSet()
    {
        string[] array = new string[] {csvDatas[index][1], csvDatas[index][2], csvDatas[index][3], csvDatas[index][4] };
        

        for(int i = 1; i <= 4; i++)
        {
            Text ansLabel = GameObject.Find("AnsButton" + i).GetComponentInChildren<Text>();
            ansLabel.text = array[i - 1];
        }
    }
 
    
}
