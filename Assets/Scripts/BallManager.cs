using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{   
    [System.Serializable]
    public class SpawnPoint{
        public GameObject PointObject;
        public int maxX;
        public int minX;
        public int maxZ;
        public int minZ;
    }

    public Transform spawnArea;
    public int maxBallAmount;
    public int spawnInterval;
    public List<GameObject> BallTemplateList;
    public List<SpawnPoint> PosisiList = new List<SpawnPoint>();

    private List<GameObject> BallList;
    public float timer;
    void Start()
    {
        BallList = new List<GameObject>();
        GenerateBall();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnInterval){
            if(BallList.Count <= maxBallAmount){
                GenerateBall();
                timer -= spawnInterval;
            }  
        }
    }

    public void GenerateBall(){
        if(BallList.Count >= maxBallAmount){
            return;
        }

        int randomIndexBall = Random.Range(0, BallTemplateList.Count);
        int randomIndexPosition = Random.Range(0, PosisiList.Count);

        GameObject ball = Instantiate(
            BallTemplateList[randomIndexBall],
            new Vector3(
                PosisiList[randomIndexPosition].PointObject.transform.position.x, 
                PosisiList[randomIndexPosition].PointObject.transform.position.y, 
                PosisiList[randomIndexPosition].PointObject.transform.position.z), 
            Quaternion.identity, 
            spawnArea);

        ball.SetActive(true);
        BallController testBola = ball.GetComponent<BallController>();
        testBola.speed = new Vector3(
            Random.Range(
                PosisiList[randomIndexPosition].minX, PosisiList[randomIndexPosition].maxX), 
                0, 
                Random.Range(PosisiList[randomIndexPosition].minZ, PosisiList[randomIndexPosition].maxZ));
        testBola.Jalan();

        BallList.Add(ball);
    }

    public void RemoveBall(GameObject ball){
        BallList.Remove(ball);
        Destroy(ball);
    }

    public void RemoveAllBall(){
        while (BallList.Count > 0)
        {
            RemoveBall(BallList[0]);
        }
    }
}
