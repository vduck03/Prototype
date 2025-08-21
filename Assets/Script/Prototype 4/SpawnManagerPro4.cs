using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerPro4 : MonoBehaviour
{
    public GameObject enemy;
    public GameObject powerUp;
    private float spawnRange = 9f;
    public int enemyCount;
    private int waveNumber = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnEnemy(waveNumber);
        Instantiate(powerUp, getSpawnPos(), powerUp.transform.rotation);
    }

    private void Update()
    {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            spawnEnemy(waveNumber);
            Instantiate(powerUp, getSpawnPos(), powerUp.transform.rotation);
        }
    }

    private void spawnEnemy(int numberEnemy)
    {
        for (int i = 0; i < numberEnemy; i++)
        {
            Instantiate(enemy, getSpawnPos(), enemy.transform.rotation);
        }
    }
    private Vector3 getSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
