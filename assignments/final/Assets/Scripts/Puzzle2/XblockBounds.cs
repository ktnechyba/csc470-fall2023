using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class XblockBounds : MonoBehaviour
{
    Vector3 mousePos;

    Vector3 view;
    PositionConstraint pos;
    private void Awake()
    {
        pos = gameObject.GetComponent<PositionConstraint>();
    }
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
    public void Update()
    {

        view = transform.position;
        //if (view.x > 3.4f) { view.x = 3.4f; }
        view.x = Mathf.Clamp(view.x, 2.03f, 15.3f);
        transform.position = new Vector3(view.x, 0f, view.z);
    }
}
