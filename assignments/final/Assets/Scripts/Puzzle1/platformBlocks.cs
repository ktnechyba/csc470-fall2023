using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBlocks : MonoBehaviour
{
    Renderer rend;
    public Material wrong;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            rend.sharedMaterial = wrong;
        }
    }

}
