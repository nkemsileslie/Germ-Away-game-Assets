using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstercles : MonoBehaviour
{   
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    public float timeBetweenSpawn;
    private float spawnTime;


    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
    }
}
