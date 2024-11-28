using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EdScript : MonoBehaviour
{
    public GameObject baloonCloneTemplate;  
    float turningspeed = 90;
    Animator edsAnimator;
    float speed;
    float walkingSpeed = 1;
    float runningMultiplier = 3;


    // Start is called before the first frame update
    void Start()
    {
        edsAnimator = GetComponent<Animator>();

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




       

        if (Input.GetKey(KeyCode.D))
        {   //Roll Left

            transform.Rotate(Vector3.up, -turningspeed * Time.deltaTime);




        }



        if (Input.GetKey(KeyCode.LeftShift))
        {

            speed *= runningMultiplier;

            edsAnimator.SetBool("IsRunning", true);
        }
        else
        {
            edsAnimator.SetBool("IsRunning", false);
        }


        






        if (Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(baloonCloneTemplate, transform.position, transform.rotation);


            

        }

        transform.position += speed * (transform.forward * Time.deltaTime);

    }
    


}