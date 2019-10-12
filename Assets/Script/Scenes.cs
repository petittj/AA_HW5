using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        KeepData.RoundsPlayed = 0;
        KeepData.HighScore = 0;
        SceneManager.LoadScene("SampleScene");
    }
    public void StartBegnning()
    {
        
        SceneManager.LoadScene("Intro");
    }

    public void StartHelp()
    {
        SceneManager.LoadScene("HELP");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;

    }

}
