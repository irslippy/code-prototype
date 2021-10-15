using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRespawn : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> Balls = new List<GameObject>();

    [SerializeField]
    GameObject[] spawnPoints;


    public bool EnableRandomize;

    

    // Start is called before the first frame update
    void Start()
    {
        OnMouseDown();


    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void SpawnBalls()
    {
        int index = EnableRandomize ? Random.Range(0, 3) : 0;

        Instantiate (Balls[index], transform.position, Quaternion.identity);
    }


    private void OnMouseDown()
    {
        SpawnBalls();
    }







}
