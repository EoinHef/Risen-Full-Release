using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable for horizontal input
    public float horizontalInput;
    //Variable to capture forward input
    public float forwardInput;
    //Variable for turn speed
    public float turnSpeed = 1.0f;
    //Variable for speed to be applied to the player
    private float speed = 8.0f;
    //Variable to set x bounds
    private float xRange = 26.0f;
    //Variable to set z bounds
    private float zRange = 18.0f;
    public bool hasPowerUp = false;
    public GameObject powerupIndicator;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x < -xRange)       
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.z < -zRange)
            {
                transform.position = new Vector3(transform.position.x, y: transform.position.y, -zRange);
            }

            if (transform.position.z > zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            }

            //Vector3 forwardInput = new Vector3(0, 0, Input.GetAxis("Vertical"));
            //Vector3 rotateInput = new Vector3(0, Input.GetAxis("Horizontal"),0);
            
            //player.MovePosition(transform.position + forwardInput * Time.deltaTime * speed);
            //player.MovePosition(transform.position + rotateInput * Time.deltaTime * turnSpeed);



            //Capturing input on the vertical axis
            forwardInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


            //Capturing input on the horizontal axis
            horizontalInput = Input.GetAxis("Horizontal");
            //Applying movement if the vertical keys are pressed
            transform.Rotate(Vector3.up * Time.deltaTime* turnSpeed * horizontalInput);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        speed = 12.0f;
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        speed = 8.0f;
        powerupIndicator.gameObject.SetActive(false);
    }
}

