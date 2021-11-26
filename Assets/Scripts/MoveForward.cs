using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Script to set the forward motion of objects in the game
    //Variable to govern object speed
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Using transform translate for movement and giving a vector for direction of translate 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}