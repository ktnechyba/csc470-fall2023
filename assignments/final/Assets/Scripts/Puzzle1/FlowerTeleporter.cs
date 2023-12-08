using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowerTeleporter : MonoBehaviour
{
    wateringCanCollection wateringCan;
    FlowerTeleporter flowerTeleporter;
    public bool watered = false;
    Renderer rend;
    public Material flowBlue;
    private void Start()
    {
        rend = gameObject.GetComponentInChildren<Renderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("portal") && watered == true)
        {
            SceneManager.LoadScene("Puzzle1Collection");
        }
        if (other.CompareTag("Player") && gameObject.CompareTag("watered"))
        {
            watered = true;
            rend.sharedMaterial = flowBlue;
            flowerTeleporter.enabled = false;
        }
        
    }
}
