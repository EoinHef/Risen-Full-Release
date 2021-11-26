using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Creating a reference to enemy prefabs
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Using random range value to make enemies spawn in different places
        float spawnPosX = Random.Range(-15, 15);
        float spawnPosZ = Random.Range(22, 50);
        //Instantiate the enemy prefabs using randomly generated locations within a range
        Instantiate(enemyPrefab, new Vector3(spawnPosX, 0, spawnPosZ), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
