using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpetTriggerScript : MonoBehaviour
{

    //[SerializeField] playerControls playerControllerScript;
    //[SerializeField] carpetControl carpetControlScript;
    [SerializeField] private GameObject carpet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<Collider>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Collider>().enabled = true;
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("carpet"))
    //    {
    //        other.transform.SetParent(transform);
    //        other.GetComponent<playerControls>().enabled = false;
    //        carpet.GetComponent<carpetControl>().enabled = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("carpet"))
    //    {
    //        other.transform.SetParent(null);
    //        if (Input.GetKeyDown(KeyCode.Escape))
    //        {
    //            other.GetComponent<playerControls>().enabled = true;
    //            carpet.GetComponent<carpetControl>().enabled = false;
    //        }

    //    }
    //}
}
