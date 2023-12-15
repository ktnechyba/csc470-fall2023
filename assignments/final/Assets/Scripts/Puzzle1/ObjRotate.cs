using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjRotate : MonoBehaviour
{
    public float turnSpeed = 50f;
    public float turnAngle = 0f;
    public bool roty = false;
    public bool rotx = false;
    private void Update()
    {
        if (roty == true&&rotx == false)
        { transform.rotation = Quaternion.Euler(new Vector3(0, turnAngle, 0)); }
        else if (rotx == true&&roty==false)
        { transform.rotation = Quaternion.Euler(new Vector3(turnAngle, -90, -90)); }
    }
    public void AdjustRotate(float newTurnAngle)
    {
        roty = true;
        rotx = false;
        turnAngle = newTurnAngle;
    }
    public void Rot(float newTurnAngle)
    {
        rotx = true;
        roty = false;
        
        turnAngle = newTurnAngle;
    }
}
