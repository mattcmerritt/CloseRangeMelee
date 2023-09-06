using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Spawns an enemy in one of the four corners of the map every few seconds
public class EnemySpawner : MonoBehaviour
{
    [Range(0, 20), SerializeField] private float SpawnDelay;
    private float TimeSinceLastSpawned;
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float xLimit, yLimit;

    private void Update()
    {
        TimeSinceLastSpawned += Time.deltaTime;
        if (TimeSinceLastSpawned >= SpawnDelay)
        {
            Instantiate(EnemyPrefab, new Vector3(Random.Range(0, 2) == 0 ? xLimit : -xLimit, Random.Range(0, 2) == 0 ? yLimit : -yLimit, 0f), Quaternion.identity);
            TimeSinceLastSpawned = 0f;
        }
    }
}
