using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdScript : MonoBehaviour
{
    public GameObject giftCloneTemplate;
    float turningSpeed = 90;
    float speed;
    float WalkingSpeed = 1;
    float RunningMultiplier = 3;
    Animator edsAnimator;

    // Start is called before the first frame update
    void Start()
    {
        edsAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(giftCloneTemplate,transform.position,transform.rotation);
        }

        transform.position +=speed * transform.forward * Time.deltaTime;

    }
}
