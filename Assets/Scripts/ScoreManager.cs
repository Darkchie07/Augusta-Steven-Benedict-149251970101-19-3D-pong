using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int firstScore;
    public int secondScore;
    public int thirdScore;
    public int fourthScore;
    public Collider Wall1;
    public Collider Wall2;
    public Collider Wall3;
    public Collider Wall4;
    public int Player = 4;
    public bool player1 = true;
    public bool player2 = true;
    public bool player3 = true;
    public bool player4 = true;
    public GameOverManager manager;

    
    
    public int maxScore;

    private void Update() {
        GameOver();
    }

    public void Player1Score(int increment){
        firstScore += increment;
        if(firstScore >= maxScore){
            Wall1.isTrigger = false;
            Player -= 1;
            player1 = false;
        }
    }

    public void Player2Score(int increment){
        secondScore += increment;
        if(secondScore >= maxScore){
            Wall2.isTrigger = false;
            Player -= 1;
            player2 = false;
        }
    }

    public void Player3Score(int increment){
        thirdScore += increment;
        if(thirdScore >= maxScore){
            Wall3.isTrigger = false;
            Player -= 1;
            player3 = false;
        }
    }

    public void Player4Score(int increment){
        fourthScore += increment;
        if(fourthScore >= maxScore){
            Wall4.isTrigger = false;
            Player -= 1;
            player4 = false;
        }
    }

    public void GameOver(){
        if(Player == 1){
            if(player1){
                manager.setup("Player 1", 0, 255, 0, 255);
            }else if(player2){
                manager.setup("Player 2", 255, 0, 254, 255);
            }else if(player3){
                manager.setup("Player 3", 0, 0, 255, 255);
            }else if(player4){
                manager.setup("Player 4", 255, 0, 0, 255);
            }
        }
    }
}
