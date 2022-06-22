using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOverManager : MonoBehaviour
{
    public Text WinnerPlayer;

    public void setup(string player, float r, float g, float b, float a){
        gameObject.SetActive(true);
        WinnerPlayer.text = player;
        WinnerPlayer.color = new Color(r, g, b, a);
    }

    public void Replay(){
        SceneManager.LoadScene("Game");
    }

    public void MainMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
