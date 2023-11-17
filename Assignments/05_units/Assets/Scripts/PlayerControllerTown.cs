using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTown : MonoBehaviour
{
    //public GameObject playerPrefab;
    private Vector3 target;
    public CharacterController cc;
    public float moveSpeed = 5;
    public bool hasTarget = false;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject playerObj = Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 amountToMove = Vector3.zero;
        if (hasTarget)
        {
            Vector3 moveTo = (target - transform.position).normalized;
            float step = 5 * Time.deltaTime;
            Vector3 rotatedTowardsVector = Vector3.RotateTowards(transform.forward, moveTo, step, 1);
            rotatedTowardsVector.y = 0;
            transform.forward = rotatedTowardsVector;
            amountToMove = transform.forward * moveSpeed * Time.deltaTime;

            cc.Move(moveTo * moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, target) < 0.005f)
            {
                hasTarget = false;
            }
        }
    }
    public void SetTarget(Vector3 targetPoint)
    {
            target = targetPoint;
            hasTarget = true;
    }
}
