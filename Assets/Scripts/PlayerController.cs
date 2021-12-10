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
    public float speed = 1.0f;
    //Variable to set x bounds
    private float xRange = 30.0f;
    //Variable to set z bounds
    private float zRange = 18.0f;
    public Rigidbody player;
    private CharacterController controller;
    private bool groundedPlayer;
    private Vector3 playerVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
        
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        
        controller.Move(playerVelocity * Time.deltaTime);
        
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
        //forwardInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


        //Capturing input on the horizontal axis
        //horizontalInput = Input.GetAxis("Horizontal");
        //Applying movement if the vertical keys are pressed
        //transform.Rotate(Vector3.up * Time.deltaTime* turnSpeed * horizontalInput);
    }
}
