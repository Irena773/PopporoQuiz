using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{

    public TextAsset csvFile; //GUIでcsvファイルを割り当て
    List<string[]> csvDatas = new List<string[]>();

    void Start()
    {
           }

    // Update is called once per frame
    void Update()
    {
        
    }
}
