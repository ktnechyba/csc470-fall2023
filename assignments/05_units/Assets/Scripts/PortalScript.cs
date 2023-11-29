using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& gameObject.CompareTag("portal"))player.transform.position = new Vector3(-1453.06f, 0, 529.55f);
        if (other.CompareTag("layer")&& gameObject.CompareTag("teleporter")) player.transform.position = new Vector3(-102.8f, 0, -217.5f);
    }
}
