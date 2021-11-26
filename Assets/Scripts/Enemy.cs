using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variable to control speed of enemy units
    public float speed = 5;
    //Creating a reference to the enemy rigidbody
    private Rigidbody enemyRb;
    //Creating a reference to the player object
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //Making the link between variable and rigidbodies and gameobjects in the scene
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Controlling enemy pathing toward player 
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
