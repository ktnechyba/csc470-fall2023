using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ZblovkBounds : MonoBehaviour
{
    Vector3 mousePos;
    float zpos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseUp()
    {

    }
    private void OnMouseDown()
    {
        mousePos = Input.mousePosition - GetMousePos();
            }
    
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePos);
        //Vector3 view = transform.position;
        //if (view.x >= 6.81f) { view.x = 6.8f; }
        //view.x = Mathf.Clamp(view.x, -6.86f, 6.8f);
        //transform.position = new Vector3(view.x, 0f, view.z);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 view = transform.position;
        //if (view.x > 3.4f) { view.x = 3.4f; }
        view.z = Mathf.Clamp(view.z, -9.82f, 3.4f);
        transform.position = new Vector3(view.x, 0f, view.z);
    }
}
