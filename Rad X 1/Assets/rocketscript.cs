using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketscript : MonoBehaviour
{
    float turningspeed = 100;
    float thrustvalue = 2;
    Vector3  velocity, acceleration;
    float gravity = 2;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        // acceleration = Vector3.zero;

        // acceleration += gravity * Vector3.down;
        
        if (Input.GetKey(KeyCode.W))

        {
            rb.AddForce(thrustvalue * transform.up);
            //transform.position += (Vector3.up * Time.deltaTime);
            // acceleration += thrustvalue * transform.up;
        }


        if (Input.GetKey(KeyCode.A))
        {   //Roll Left

            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {   //Pitch Up




            transform.Rotate(Vector3.right, turningspeed * Time.deltaTime);
        }

        //roll using mouse

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * turningspeed * Time.deltaTime);

        transform.Rotate(Vector3.right, Input.GetAxis("Horizontal") * turningspeed * Time.deltaTime);

        //velocity += acceleration * Time.deltaTime;


        //transform.position = velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }

}
    



