using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float timeToSpawn = 2;
    private float timerMax = 1;
    private float timer;
    private float spawnRangeX = 15.0f;
    private float spawnRangeZ = 20.0f;

    private void Start()
    {
        InvokeRepeating("SpawnAnimal", timeToSpawn, timerMax);
    }

    void Update()
    {
        // timer += Time.deltaTime;
        // if (timer >= timerMax)
        // {
        //     SpawnAnimal();
        //     timer = 0;
        // }
    }

    private void SpawnAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos,
            animals[animalIndex].transform.rotation);
    }
}
