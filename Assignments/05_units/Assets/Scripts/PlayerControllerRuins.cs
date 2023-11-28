using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRuins : MonoBehaviour
{
    float forwardSpeed = 10f;
    float rotateSpeed = 90f;
    CharacterController cc;
    float yVelocity = 0f;
    float jumpForce = 12f;
    float gravityModifier = 4.5f;
    Vector3 oldCamPos;

    Camera cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
        cameraObject = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
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
        Vector3 amountToMove = vAxis * transform.forward * forwardSpeed;
        amountToMove.y = yVelocity;

        cc.Move(amountToMove * Time.deltaTime);

        Vector3 newCamPos = transform.position + -transform.forward * 3f + Vector3.up * 3f;
        if (oldCamPos == null)
        {
            oldCamPos = newCamPos;
        }
        cameraObject.transform.position = (newCamPos + oldCamPos) / 2f;
        cameraObject.transform.LookAt(transform);
        oldCamPos = newCamPos;


    }



}
