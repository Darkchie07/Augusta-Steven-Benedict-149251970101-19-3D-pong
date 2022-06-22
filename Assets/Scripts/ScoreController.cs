using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scorePlayer1;
    public Text scorePlayer2;
    public Text scorePlayer3;
    public Text scorePlayer4;
    
    public ScoreManager manager;

    private void Update(){
        scorePlayer1.text = manager.firstScore.ToString();
        scorePlayer2.text = manager.secondScore.ToString();
        scorePlayer3.text = manager.thirdScore.ToString();
        scorePlayer4.text = manager.fourthScore.ToString();
    }
}
