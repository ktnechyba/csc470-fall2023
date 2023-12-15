using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 mousePos;
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown()
    {
        mousePos = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePos);
    }
}
