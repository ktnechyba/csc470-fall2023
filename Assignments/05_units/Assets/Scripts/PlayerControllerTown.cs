using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerControllerTown : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera cam;
    Vector3 oldCamPos;
    ////public GameObject playerPrefab;
    //private Vector3 target;
    //public CharacterController cc;
    //public float moveSpeed = 5;
    //public bool hasTarget = false;
    //// Start is called before the first frame update
    void Start()
    {
        //GameObject playerObj = Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 amountToMove = Vector3.zero;
        //if (hasTarget)
        //{
        //    Vector3 moveTo = (target - transform.position).normalized;
        //    float step = 5 * Time.deltaTime;
        //    Vector3 rotatedTowardsVector = Vector3.RotateTowards(transform.forward, moveTo, step, 1);
        //    rotatedTowardsVector.y = 0;
        //    transform.forward = rotatedTowardsVector;
        //    amountToMove = transform.forward * moveSpeed * Time.deltaTime;

        //    cc.Move(moveTo * moveSpeed * Time.deltaTime);
        //    if (Vector3.Distance(transform.position, target) < 0.005f)
        //    {
        //        hasTarget = false;
        //    }
        //}

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
                GameObject.FindGameObjectWithTag("stars").GetComponent<StarTriggerManager>().IsNotTriggered();
                GameObject.FindGameObjectWithTag("potions").GetComponent<ShopTriggerManager>().IsNotTriggered();
                StartCoroutine(BoxCollide());

            }
        }
        Vector3 newCamPos = transform.position + -transform.forward * 3f + Vector3.up * 3f;
        if (oldCamPos == null)
        {
            oldCamPos = newCamPos;
        }
        cam.transform.position = (newCamPos + oldCamPos) / 2f;
        cam.transform.LookAt(transform);
        oldCamPos = newCamPos;

    }

    IEnumerator BoxCollide()
    {
        yield return new WaitForSeconds(30);
        GameObject.FindGameObjectWithTag("potions").GetComponent<BoxCollider>().enabled = true;
        GameObject.FindGameObjectWithTag("stars").GetComponent<BoxCollider>().enabled = true;
    }
    //public void SetTarget(Vector3 targetPoint)
    //{
    //        target = targetPoint;
    //        hasTarget = true;
    //}

}
