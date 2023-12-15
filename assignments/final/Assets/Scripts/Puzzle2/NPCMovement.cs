using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCMovement : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    [SerializeField] float speed = 1f;
    public bool completed1;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        completed1 = GameObject.FindGameObjectWithTag("watererd").GetComponent<EscapeBlock>().completed1;
        if (completed1 == true)
        {
            //set active false
            //gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
        }
    }

    public void MainMen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
