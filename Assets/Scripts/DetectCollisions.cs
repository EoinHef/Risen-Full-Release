using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject zombieType1;
    public GameObject zombieType2;

    // Start is called before the first frame update
    void Start()
    {
        //Making a reference to the game manager object so this script can find it
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        zombieType1 = GameObject.FindWithTag("Zombie1");
        zombieType2 = GameObject.FindWithTag("Zombie2");
    }
    //Using on trigger function to govern what happens after collisions
    private void OnTriggerEnter(Collider other)
    {
        //Make sure enemy colliding with the plane doesnt despawn it
        if (other.transform.CompareTag("Ground"))
        {
            //do Nothing
        }
        //Logic for bullet prefab collisions
        else if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            if (gameObject == zombieType1)
            {
                gameManager.UpDateScore(10);
            }
            else if (gameObject == zombieType2)
            {
                gameManager.UpDateScore(20);
            }
        }
        //Logic for player collisions
        else if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject); 
            gameManager.GameOver();
        }
    }
}
