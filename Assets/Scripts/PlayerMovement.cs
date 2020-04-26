using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float movementSpeed = 2000f;
    public float steeringSpeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Fixed Update is used for Physics stuff
    private void FixedUpdate()
    {
        // Add constant movement in z
        rb.AddForce(0, 0, movementSpeed * Time.deltaTime);

        // Steer to the right by pressing the "D" button
        if (Input.GetKey("d"))
        {
            rb.AddForce(steeringSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        
        // Steer to the left by pressing the "A" button
        if (Input.GetKey("a"))
        {
            rb.AddForce(-steeringSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
    }
}
