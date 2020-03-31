using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeFlight : MonoBehaviour
{

    public Rigidbody rB;
    rB = GetComponent<Rigidbody>();
    float moveRight = 500f;
    // Update is called once per frame
    void Update()
    {
        processInput();
    }

    private void processInput()
    {

        if ((Input.GetKey("a")))
        {
            Debug.Log("Nigga moving left");
        }
        else if ((Input.GetKey("d")))
        {
            rB.AddForce(moveRight * 0 * 0 * Time.deltaTime);
        }

        else if (Input.GetKey("space"))
        {

        }
        else
        {

        }
    }
}
        
    


