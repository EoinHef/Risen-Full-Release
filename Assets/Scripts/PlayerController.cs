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
    public float speed = 10.0f;
    //Variable to set x bounds
    private float xRange = 20.0f;
    //Variable to set z bounds
    private float zRange = 14.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Setting the bounds using x and z range variable
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, y: transform.position.y,-zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,zRange);
        }
        //Capturing input on the vertical axis
        forwardInput = Input.GetAxis("Vertical");
        //Applying movement if the horizontal keys are pressed
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Capturing input on the horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        //Applying movement if the vertical keys are pressed
        transform.Rotate(Vector3.up * Time.deltaTime* turnSpeed * horizontalInput);
    }
}
