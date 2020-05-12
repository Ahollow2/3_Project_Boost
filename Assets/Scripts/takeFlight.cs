using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Vector3 direction = otherObject.position - transform.position;
 Quaternion toRotation = Quaternion.FromToRotation(transform.up, direction);
 transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, speed * Time.time);*/

public class takeFlight : MonoBehaviour
{

    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float mainThrust = 25f;
    AudioSource audiosource;

    public Rigidbody rigidBody;

    float speed = 100f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Thrust();
            Rotate();
    }



    private void Rotate()
    {
        
        float rotationThisFrame = rcsThrust * Time.deltaTime;
        rigidBody.freezeRotation = true; // take manual control of rotation 
        if ((Input.GetKey("a")))
        {
            
            transform.Rotate(-Vector3.right * speed  * rotationThisFrame * Time.deltaTime);
        }

       else if ((Input.GetKey("d")))
        {
            transform.Rotate(Vector3.right * speed * rotationThisFrame * Time.deltaTime);
        }
        rigidBody.freezeRotation = false; // Resume phyics control of rotation 

    }

    private void Thrust()
    {



         if (Input.GetKey("space"))
        {
            rigidBody.AddRelativeForce(Vector3.up * speed * mainThrust * Time.deltaTime);
        }
        else
        {

        }
    }

}
        
    


