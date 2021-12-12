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
        //Call to function,sets initial enemies to spawn
        SpawnEnemyWave(2);
    }

    // Update is called once per frame
    void Update()
    {
        //Storing the amount of enemies alive so can use logic to spawn more when certain amount left
        enemyCount = GameObject.FindGameObjectsWithTag("Zombie1");
        enemiesAlive = enemyCount.Length;
        if (enemiesAlive <= 1)
        {
            SpawnEnemyWave(2);
        }
    }
    //Method to spawn enemies,uses passed interger value to decide how many to spawn,spawn position is set between two bounds
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
