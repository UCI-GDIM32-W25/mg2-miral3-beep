using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float minSpawnInterval = 2.0f;
    [SerializeField] private float maxSpawnInterval = 5.0f;
    [SerializeField] private float spawnX = 12f;
    [SerializeField] private int minCoinsPerSpawn = 1;
    [SerializeField] private int maxCoinsPerSpawn = 3;
    [SerializeField] private float spacing = 1.0f;
    
    private float timer;
    private float currentInterval;
    
    void Update()
    {
        if (GameController.Instance.gameStarted)
        {
            timer += Time.deltaTime;
            
            if (timer >= currentInterval)
            {
                SpawnCoin();
                timer = 0f;
                currentInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            }
        }
    }
    
    void SpawnCoin()
    {
         if (coinPrefab != null)
        {
            int randomAmount = Random.Range(minCoinsPerSpawn, maxCoinsPerSpawn + 1);
            for (int i = 0; i < randomAmount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnX + (i * spacing), transform.position.y, 0);
                Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}