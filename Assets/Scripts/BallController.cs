using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public int force = 75;
    private Rigidbody rig;
    private float timer;
    public BallManager manager;

    // private void Start() {
         
    // }

    private void Update() {
        // timer += Time.deltaTime;
        // if(timer > 5){
        //     force += 100;
        //     timer = 0;
        // }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Wall"){
            manager.RemoveBall(gameObject);
        }
    }

    public void Jalan(){
        rig = GetComponent<Rigidbody>();
        rig.AddForce(speed * force);
    }

}
