using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartButtonScript : MonoBehaviour
{
   [SerializeField] GameObject option_Panel;

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void OnClickOptionButton()
    {
        option_Panel.SetActive(true);
    }

    public void OnClickBackTitleButton()
    {
        option_Panel.SetActive(false);
    }

    public void OnClickExitButton()
    {
        UnityEditor.EditorApplication.isPlaying = false;

        UnityEngine.Application.Quit();
    }

    
}
