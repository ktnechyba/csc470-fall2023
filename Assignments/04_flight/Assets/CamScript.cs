using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W)) move.z = +1f;
        if (Input.GetKey(KeyCode.S)) move.z = -1f;
        if (Input.GetKey(KeyCode.A)) move.x = -1f;
        if (Input.GetKey(KeyCode.D)) move.x = +1f;
        Vector3 moveDirection = transform.forward * move.z + transform.right * move.x;
        float moveSpeed = 30f;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        float rotateDirection = 0f;
        if (Input.GetKey(KeyCode.Q)) rotateDirection = +1f;
        if (Input.GetKey(KeyCode.E)) rotateDirection = -1f;
        float rotateSpeed = 50f;
        transform.eulerAngles += new Vector3(0, rotateDirection * rotateSpeed * Time.deltaTime, 0);
    }
}
