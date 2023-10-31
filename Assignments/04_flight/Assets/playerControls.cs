using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    //player image from "Bongo Cat Pumpkin by Neil Realubit [CC-BY] via Poly Pizza"
    float forwardSpeed = 10f;
    float rotateSpeed = 90f;
    CharacterController cc;
    float yVelocity = 0f;
    float jumpForce = 12f;
    float gravityModifier = 4.5f;
    Vector3 oldCamPos;

    public GameObject cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
        GameManagerScript.SharedInstance.UpdateScore(0);

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

        Vector3 newCamPos = transform.position + -transform.forward * 2f + Vector3.up * 1.4f;
        if (oldCamPos == null)
        {
            oldCamPos = newCamPos;
        }
        cameraObject.transform.position = (newCamPos + oldCamPos) / 2f;
        cameraObject.transform.LookAt(transform);
        oldCamPos = newCamPos;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckVillagerTalking();
        }
    }
    void CheckVillagerTalking()
    {
        GameObject[] villagers = GameObject.FindGameObjectsWithTag("villager");
        float closest = 999999999;
        GameObject closestVillager = null;
        for (int i = 0; i < villagers.Length; i++)
        {
            float d = Vector3.Distance(transform.position, villagers[i].transform.position);
            if (d < closest)
            {
                closest = d;
                closestVillager = villagers[i];
            }
        }

        if (closestVillager != null)
        {
            Vector3 vectorToChicken = (closestVillager.transform.position - transform.position).normalized;
            float angleToChicken = Vector3.Angle(transform.forward, vectorToChicken);
            if (angleToChicken < 45)
            {
                GameManagerScript.SharedInstance.Launchdialogue(closestVillager.GetComponent<VillagerScript>());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("candy")) 
        {
            GameManagerScript.SharedInstance.UpdateScore(1);
            Destroy(other.gameObject);

        }
        if (other.CompareTag("carpetTrigger"))
        {
            Debug.Log("entered");
            //GameObject.Find("carpet").transform.SetParent(transform);
            this.enabled = false;
            GameObject.Find("carpet").GetComponent<carpetControl>().enabled = true;
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    this.enabled = true;
            //    GameObject.Find("carpet").GetComponent<carpetControl>().enabled = false;
            //}
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("carpetTrigger"))
    //    {
    //        Debug.Log("exit");
    //        //GameObject.Find("carpet").transform.SetParent(null);
    //        if (Input.GetKeyDown(KeyCode.Space))
    //        {
    //            this.GetComponent<playerControls>().enabled = true;
    //            GameObject.Find("carpet").GetComponent<carpetControl>().enabled = true;
    //        }

    //    }
    //}
}
