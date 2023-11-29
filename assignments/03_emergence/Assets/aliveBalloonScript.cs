using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliveBalloonScript : MonoBehaviour
{
    Renderer rend;
    public int x = -1;
    public int z = -1;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponentInChildren<Renderer>();
        rend.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }

    public void DestroyAliveB()
    {
        Destroy(this.gameObject);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("arrow"))
        {
            DestroyAliveB();


        }
    }

}
