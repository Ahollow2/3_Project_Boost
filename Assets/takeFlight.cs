using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeFlight : MonoBehaviour
{
    AudioSource audiosource;

    public Rigidbody rigidBody;
   
    float speed = 100f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        processInput();
    }

    private  void processInput()
    {

        if ((Input.GetKey("a")))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else if ((Input.GetKey("d")))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }

        else if (Input.GetKey("space"))
        {
            rigidBody.AddRelativeForce(Vector3.up * speed * Time.deltaTime);
        }
        else
        {

        }
    }
}
        
    


