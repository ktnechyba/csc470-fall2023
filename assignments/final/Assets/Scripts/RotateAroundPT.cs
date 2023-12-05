using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPT : MonoBehaviour
{
    public Transform cameraJig;
    public float rotateSpeed;

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.RotateAround(cameraJig.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.P))
        {
            transform.RotateAround(cameraJig.position, -Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
