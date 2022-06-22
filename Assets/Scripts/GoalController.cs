using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider wall1;
    public Collider wall2;
    public Collider wall3;
    public Collider wall4;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision) {
        if(collision == wall1){
            manager.Player1Score(1);
            Debug.Log("Nabrak");
        }else if(collision == wall2){
            manager.Player2Score(1);
            Debug.Log("Nabrak");
        }else if(collision == wall3){
            manager.Player3Score(1);
            Debug.Log("Nabrak");
        }else if(collision == wall4){
            manager.Player4Score(1);
            Debug.Log("Nabrak");
        }
    }
}
