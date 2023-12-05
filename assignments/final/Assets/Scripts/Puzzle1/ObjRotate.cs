using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjRotate : MonoBehaviour
{
    public float turnSpeed = 50f;
    public float turnAngle = 0f;
    private void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, turnAngle, 0));
    }
    public void AdjustRotate(float newTurnAngle)
    {
        turnAngle = newTurnAngle;
    }
}
