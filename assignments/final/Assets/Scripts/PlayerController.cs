using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    public Animator animator;
    public Camera cam;
    Vector3 oldCamPos;

    public GameObject keyPlat;
    public GameObject fakePlat;
    public GameObject exitPlat;


    bool walking = false;
    bool toRun = false;
    bool isIdle = false;


    float forwardSpeed = 5f;
    float rotateSpeed = 85f;

    float yVelocity = 0f;
    float jumpForce = 12f;
    float gravityModifier = 4.5f;
    public Vector3 amountToMove;

    public GameObject barrier;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Vector3 pos = transform.position;
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
        if(transform.position.y < 4f)
        {
            keyPlat.SetActive(false);
            fakePlat.SetActive(false);
            exitPlat.SetActive(false);
        }
        else
        {
            keyPlat.SetActive(true);
            fakePlat.SetActive(true);
            exitPlat.SetActive(true);
        }

        if(transform.position.y < 0)
        {
            transform.position = pos;
        }
        
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("door"))
        {
            this.enabled = false;
            GameObject.FindGameObjectWithTag("door").GetComponent<DoorTrigger>().enabled = true;

        }
        if (other.CompareTag("npc"))
        {
            if (other.CompareTag("Player"))
            {
                barrier.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }

}
