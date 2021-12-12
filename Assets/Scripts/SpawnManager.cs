using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnXRange = 27;
    private float spawnZRange = 18;
    public GameObject enemyPrefab;
    public GameObject[] enemyCount;
    public int enemiesAlive;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(2);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Zombie1");
        enemiesAlive = enemyCount.Length;
        if (enemiesAlive <= 1)
        {
            SpawnEnemyWave(2);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            float spawnPosX = Random.Range(-spawnXRange, -29);
            float spawnPosZ = Random.Range(-spawnZRange, -20);
            Instantiate(enemyPrefab, new Vector3(spawnPosX, 0, spawnPosZ), enemyPrefab.transform.rotation);
        }
    }

   
}
