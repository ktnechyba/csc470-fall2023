using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wateringCanCollection : MonoBehaviour
{
    public bool can = false;


    public void Awake()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            can = true;
            gameObject.SetActive(false);
        }
    }
}
