using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unused : MonoBehaviour
{

    //PURPOSE: This script will allow the player to control demi-fiend within the overworld

    //Global Variables
    public float mvmntSpd = 50f; //movement speed
    public float rotationSpeed = 50f;


    void Start()
    {

    }


    //Movement 
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * mvmntSpd; //Vertical Movement [e.g) WASD or Arrow Keys]
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed; //Horizontal Movement [e.g) WASD or Arrow Keys]
        
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
