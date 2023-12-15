using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCamera : MonoBehaviour
{
    public GameObject rotCam;
    public Camera playCam;
    public int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Rot()
    {
        rotCam.SetActive(true);
        playCam.enabled = false;
    }
    public void PlayCam()
    {
        rotCam.SetActive(false);
        playCam.enabled = true;
    }
}
