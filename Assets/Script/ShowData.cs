using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelSpeedText;
    public Text PanelScoreText;
    public Text PanelHighScoreText;
    public Text PanelRoundsPlayedText;



    private void Awake()
    {
        PanelNameText.text = "Player: " + KeepData.PlayerName;
        PanelLivesText.text = "Lives: " + KeepData.PlayerLives.ToString();
        PanelSpeedText.text = "Rotation Speed: " + KeepData.PlayerSpeed.ToString();
        PanelHighScoreText.text = "High Score: " + KeepData.HighScore.ToString();
        PanelRoundsPlayedText.text = "Rounds: " + KeepData.RoundsPlayed.ToString();
        PanelScoreText.text = "Score: " + Score.PinCount.ToString();
    }
   private void Update()
    {
        //PanelScoreText.text = "Score: " + Score.PinCount.ToString();
    }
}
