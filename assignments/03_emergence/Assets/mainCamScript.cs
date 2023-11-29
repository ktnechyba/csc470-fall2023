using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamScript : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
      
    }
    float inputX, inputZ;
    //Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        if (inputX != 0)
            Rotate();
        if (inputZ != 0)
            Move();
    }
    private void Move()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime*20;
    }
    private void Rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime*20, 0f));
    }
}