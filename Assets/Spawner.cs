using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject imposterPrefab;
    [SerializeField] GameObject crewmatePrefab;
    [SerializeField] float spawnRate = 2f;
    [SerializeField] float spawnRange = 5f;

    float nextSpawnTime = 0f;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void Spawn()
    {
        Vector2 randomPosition = (Vector2)transform.position + Random.insideUnitCircle * spawnRange;
        Instantiate(imposterPrefab, randomPosition, Quaternion.identity);
        Instantiate(crewmatePrefab, randomPosition, Quaternion.identity);
    }
}
