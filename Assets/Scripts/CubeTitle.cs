using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Script just rotates the cube on the title screen
        transform.Rotate(Vector3.up * (Time.deltaTime * 5 * 10)); 
        transform.Rotate(Vector3.right * (Time.deltaTime * 5 * 10)); 
    }
}
