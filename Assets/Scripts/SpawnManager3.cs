using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    //Variable and references
    private float spawnXRange = 25;

    private float spawnZRange = 18;
    public GameObject enemyPrefab;
    public GameObject powerUp;
    public GameObject[] enemyCount;
    public GameObject[] powerUpCount;
    public int enemiesAlive;
    public int powerUps;
    
    // Start is called before the first frame update
    void Start()
    {
        //Call methods to spawn enemies and powerups
        SpawnEnemyWave(2);
        PowerUpSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        //Finishing referencing game objects
        enemyCount = GameObject.FindGameObjectsWithTag("Zombie2");
        enemiesAlive = enemyCount.Length;
        powerUpCount = GameObject.FindGameObjectsWithTag("Powerup");
        powerUps = powerUpCount.Length;
        //Logic to decide when to spawn enemies and power ups
        if (enemiesAlive== 0)
        {
            SpawnEnemyWave(2);
        }

        if (powerUps == 0)
        {
            PowerUpSpawn();
        }
    }
    //Method to spawn enemies
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            float spawnPosX = Random.Range(spawnXRange, 29);
            float spawnPosZ = Random.Range(spawnZRange, 20);
            Instantiate(enemyPrefab, new Vector3(spawnPosX, 0, spawnPosZ), enemyPrefab.transform.rotation);
        }
    }
    //Method to spawn powerup
    void PowerUpSpawn()
    {
        float spawnPosX = Random.Range(-24, 24);
        float spawnPosZ = Random.Range(-15, 15);
        Instantiate(powerUp, new Vector3(spawnPosX, 1, spawnPosZ), powerUp.transform.rotation);
    }
}