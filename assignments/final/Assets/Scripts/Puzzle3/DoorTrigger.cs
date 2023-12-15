using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (CharacterSelect.shared_instance.mage == true)
            {
                GameObject.FindGameObjectWithTag("player").transform.SetParent(null);
                GameObject.FindGameObjectWithTag("player").GetComponent<PlayerController>().enabled = true;
                this.enabled = false;
            }
            if (CharacterSelect.shared_instance.sword == true)
            {
                GameObject.FindGameObjectWithTag("Player").transform.SetParent(null);
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = true;
                this.enabled = false;
            }



        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.enabled == true)
        {
            other.transform.SetParent(transform);
        }
        if (other.CompareTag("player") && this.enabled == true)
        {
            other.transform.SetParent(transform);
        }
    }
}
