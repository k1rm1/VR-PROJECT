using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnInterval;
    [SerializeField] private int maxEnemiesNumber;
    [SerializeField] private Transform player;

    private List<GameObject> spawnedEnemies = new List<GameObject>();
    private float timeSinceLastSpawnl;
    private float currentEnemiesNumber;

    private void Start()
    {
        timeSinceLastSpawnl = spawnInterval;
    }
    private void Update()
    {
        timeSinceLastSpawnl = Time.deltaTime;
        if(timeSinceLastSpawnl > spawnInterval)
        {
            timeSinceLastSpawnl = 0;
            if( currentEnemiesNumber< maxEnemiesNumber)
            {
                SpawnEnemy();
            }
        }
    }

    private void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
