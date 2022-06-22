using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPad : MonoBehaviour
{
    private Rigidbody rig;
    public float timer;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private void Start() {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // if(speed != 4){
        //     timer += Time.deltaTime;
        //     if(timer >= 5){
        //         speed /= 2;
        //         timer = 0;
        //     }
        // }
        moveObject(GetInput());
    }

    private Vector3 GetInput(){
        if(Input.GetKey(upKey)){
            return Vector3.back * speed;
        }else if(Input.GetKey(downKey)){
            return Vector3.forward * speed;
        }

        return Vector3.zero;
    }

    private void moveObject(Vector3 movement){
        // Debug.Log("Kecepatan Pedal : " + movement);
        rig.velocity = movement;
    }
}
