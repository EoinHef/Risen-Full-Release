using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    //Variable referencing the bullet prefab
    public Rigidbody bulletPrefab;
    //A transform for the bullet to be instantiated from
    public Transform launcher;
    //Force applied to the bullet once instantiated
    public float fireForce = 500;
    public float fireRate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Condition to check for if space is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Call Method to fire bullet
            fireBullet();
        }
    }
    //Method to fire a prefab bullet
    private void fireBullet()
    {
        //Using a variable to control instantiate of prefab bullets
        var projectileInstance = Instantiate(
            bulletPrefab,
            launcher.position,
            launcher.rotation);
        //Applying force to the instantiated bullet prefab
        projectileInstance.GetComponent<Rigidbody>().AddForce(transform.forward * fireForce,ForceMode.Impulse);
        //Destroying the bullet prefab after a set period of time
        Destroy(projectileInstance.gameObject,5f);
    }
    
}
