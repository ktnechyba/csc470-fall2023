using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    public Animator animator;
    public Camera cam;
    Vector3 oldCamPos;

    bool walking = false;
    bool toRun = false;
    bool isIdle = false;

    //public float gravity = -19.62f;
    //public float speed = 12f;
    //public float jumpHeight = 3f;
    //public float rotateSpeed = 60f;

    //public Transform groundCheck;
    //public float groundDis = 0.4f;

    //public LayerMask ground;

    //Vector3 velocity;
    //bool isGrounded;

    float forwardSpeed = 5f;
    float rotateSpeed = 85f;

    float yVelocity = 0f;
    float jumpForce = 12f;
    float gravityModifier = 4.5f;
    public Vector3 amountToMove;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDis, ground);

        //if (isGrounded&& velocity.y < 0)
        //{
        //    velocity.y = -2f;
        //}

        //float xAxis = Input.GetAxis("Horizontal");
        //float zAxis = Input.GetAxis("Vertical");
        //transform.Rotate(0, xAxis * rotateSpeed * Time.deltaTime, 0, Space.Self);


        //Vector3 move = transform.right * xAxis+transform.forward * zAxis;

        //cc.Move(move*speed*Time.deltaTime);
        ////step offset to go up stairs

        //if(Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}

        //velocity.y += gravity * Time.deltaTime;
        //cc.Move(velocity*Time.deltaTime);

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.Self);

        if (!cc.isGrounded)
        {

            yVelocity += Physics.gravity.y * gravityModifier * Time.deltaTime;
        }
        else
        {

            yVelocity = -1;


            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpForce;
            }
        }
        amountToMove = vAxis * transform.forward * forwardSpeed;
        amountToMove.y = yVelocity;

        cc.Move(amountToMove * Time.deltaTime);
        Debug.Log(amountToMove);
        CheckMovement();
        Vector3 newCamPos = transform.position + -transform.forward * 5f + Vector3.up * 8f;
        if (oldCamPos == null)
        {
            oldCamPos = newCamPos;
        }
        cam.transform.position = (newCamPos + oldCamPos) / 2f;
        cam.transform.LookAt(transform);
        oldCamPos = newCamPos;
    }

    public void CheckMovement()
    {
        if (amountToMove.z != 0 &&Input.GetKey(KeyCode.O))
        {
            forwardSpeed = 9;
            animator.SetBool("walking", walking = false);
            animator.SetBool("toRun", toRun = true);
            animator.SetBool("isIdle", isIdle = false);


        }
        else if (amountToMove.z != 0)
        {
            forwardSpeed = 4;
            animator.SetBool("isIdle", isIdle = false);
            animator.SetBool("walking", walking = true);
            animator.SetBool("toRun", toRun = false);

        }
        else
        {
            forwardSpeed = 4;
            animator.SetBool("isIdle", isIdle = true);
            animator.SetBool("walking", walking = false);
            animator.SetBool("toRun", toRun = false);

        }
    }
}
