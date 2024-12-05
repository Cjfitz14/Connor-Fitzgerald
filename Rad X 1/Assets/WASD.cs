using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    float turningspeed = 90;
    Animator edsAnimator;
    float speed;
    float walkingSpeed = 1;
    float runningMultiplier = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        speed = 0;
        edsAnimator.SetBool("IsWalking", false);
        if (Input.GetKey(KeyCode.W))

        {
            speed = walkingSpeed;
           

            edsAnimator.SetBool("IsWalking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);

        }
        if (!Input.GetKey(KeyCode.S))
        {
            speed = -walkingSpeed;

            edsAnimator.SetBool("IsWalking", true);


            return;
        }





    }
}
