using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRedBall : MonoBehaviour
{
    public GameObject Ball;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBall()
    {
        Instantiate(Ball, spawnPoint.position, Quaternion.identity);
    }

}
