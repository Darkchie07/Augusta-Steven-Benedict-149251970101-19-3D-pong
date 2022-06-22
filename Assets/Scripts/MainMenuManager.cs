using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuManager : MonoBehaviour
{
    public void Game(){
        SceneManager.LoadScene("Game");
    }

    public void HowTp(){
        SceneManager.LoadScene("How to Play");
    }

    public void Exit(){
        Application.Quit();
    }
}
