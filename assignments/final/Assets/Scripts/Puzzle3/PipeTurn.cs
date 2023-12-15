using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTurn : MonoBehaviour
{
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
    }
    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
}
