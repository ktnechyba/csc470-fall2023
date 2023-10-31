using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpetControl : MonoBehaviour
{
    private float forwardSpeed = 25f, sideSpeed = 7.5f, upDownSpeed = 5f;
    private float activeFSpeed, activeSSpeed, activeUDSpeed;
    private float forwardAccel = 2.5f, sideAccel = 2.5f, udAccel = 2.5f;

    public float rotateSpeed = 10f;

    Vector3 oldCamPos;

    public GameObject cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        //input
        activeFSpeed = Mathf.Lerp(activeFSpeed, Input.GetAxis("Vertical") * forwardSpeed, forwardAccel * Time.deltaTime);
        activeSSpeed = Mathf.Lerp(activeSSpeed, Input.GetAxis("Horizontal") * sideSpeed, sideAccel * Time.deltaTime);
        activeUDSpeed = Mathf.Lerp(activeUDSpeed, Input.GetAxis("Hover") * upDownSpeed, udAccel * Time.deltaTime);

        transform.position += transform.forward * activeFSpeed * Time.deltaTime + (transform.right * activeSSpeed * Time.deltaTime) + (transform.up * activeUDSpeed * Time.deltaTime);
        transform.Rotate(0, activeSSpeed * rotateSpeed * Time.deltaTime, 0, Space.Self);

        // GRAVITY
        forwardSpeed -= transform.forward.y * 15 * Time.deltaTime;
        forwardSpeed = Mathf.Max(0, forwardSpeed);

        // CAMERA
        Vector3 newCamPos = transform.position + -transform.forward * 6 + Vector3.up * 3;
        if (oldCamPos == null)
        {
            oldCamPos = newCamPos;
        }
        cameraObject.transform.position = (newCamPos + oldCamPos) / 2f;
        cameraObject.transform.LookAt(transform);
        oldCamPos = newCamPos;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("player").transform.SetParent(null);
            this.enabled = false;
            GameObject.Find("player").GetComponent<playerControls>().enabled = true;


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.enabled == true)
        {
            other.transform.SetParent(transform);
        }
                           //other.transform.SetParent(null);
            //this.enabled = false;
            //GameObject.Find("player").GetComponent<playerControls>().enabled = true;
        
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {

            //other.transform.SetParent(null);
            //this.enabled = false;
            //GameObject.Find("Player").GetComponent<playerControls>().enabled = true;

    //    }
    //}


}

