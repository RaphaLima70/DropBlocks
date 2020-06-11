using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksSpawner : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;
    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    public void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPos.Length);

        for (int i = 0; i < spawnPos.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPos[i].position, Quaternion.identity);
            }
        }
    }

}
