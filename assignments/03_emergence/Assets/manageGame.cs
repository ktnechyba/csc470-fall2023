using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manageGame : MonoBehaviour
{
    public GameObject arrowPrefab;

    public Transform launcherTransform;

    public int score = 0;
    public mainCamScript mainCamera;
    public TMP_Text scoreText;
    //private Vector3 aim;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
        GameObject mainCameraObj = GameObject.FindWithTag("MainCamera");
        mainCamera = mainCameraObj.GetComponent<mainCamScript>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Return))
        {
 
            GameObject arrow = Instantiate(arrowPrefab, launcherTransform.position, Quaternion.LookRotation(Vector3.down));
            Rigidbody arrowRB = arrow.GetComponent<Rigidbody>();
            arrowRB.AddForce(launcherTransform.forward * 1000);
            float moveVertical = Input.GetAxis("Vertical");

            //Vector3 movement = mainCamera.transform.forward * moveVertical * 10;

            //arrowRB.AddForce(movement);

        }
        
    }

    //void FixedUpdate()
    //{
    //    float moveVertical = Input.GetAxis("Vertical");

    //    Vector3 movement = mainCamera.transform.forward * moveVertical * speed;

    //    arrowRB.AddForce(movement);
    //}
    public void incScore(int howMuch)
    {
        score += howMuch;
        scoreText.text = score.ToString();
    }
    public void decrScore(int howMuch)
    {
        score -= howMuch;
        scoreText.text = score.ToString();
    }
}
