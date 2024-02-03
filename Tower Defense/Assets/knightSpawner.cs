using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightSpawner : MonoBehaviour
{
    public GameObject knight; 
    public float spawnInterval = 1.0f; 
    private float lastSpawnTime;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnInterval)
        {
            SpawnKnight();
            lastSpawnTime = Time.time;
        }
    }
}
