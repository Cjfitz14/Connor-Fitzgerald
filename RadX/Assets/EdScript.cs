using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EdScript : MonoBehaviour
{
    
    float turningSpeed = 110;
    float speed;
    float WalkingSpeed = 1;
    float RunningMultiplier = 3;
    float JumpForce = 3;
    Animator edsAnimator;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        edsAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        edsAnimator.SetBool("OnGround", true);
        edsAnimator.SetBool("IsWalking", false);
        speed = 0;

        if (Input.GetKey(KeyCode.W))
        {
            speed = WalkingSpeed;
        
          edsAnimator.SetBool("IsWalking", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed = -WalkingSpeed;
            edsAnimator.SetBool("IsWalking", true);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed *= RunningMultiplier;
            edsAnimator.SetBool("IsRunning", true);
        }
        else
        {
            edsAnimator.SetBool("IsRunning", false);
        }


        if (Input.GetKey(KeyCode.A))
        {
            
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
           
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)) ;
        { if (bool."OnGround" = true);
            { 
            rb.AddForce(JumpForce * Vector3.up, ForceMode.Impulse);
            edsAnimator.SetBool("IsJumping", true);
            edsAnimator.SetBool("OnGround", false);
            // Instantiate(giftCloneTemplate,transform.position,transform.rotation);
            }
        }
        else
        {
            edsAnimator.SetBool("IsJumping", false);
            edsAnimator.SetBool("OnGround", true);
        }

        transform.position +=speed * transform.forward * Time.deltaTime;

    }
}
