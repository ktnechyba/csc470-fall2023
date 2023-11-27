using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    //public GameObject starUnitPrefab;
    public GameObject playerPrefab;
    private Vector3 target;
    PlayerControllerTown pc;
    //GameObject player;

    //[SerializeField] StarScript stars;
    // Start is called before the first frame update

    private void Awake()
    {
        sharedInstance = this;
    }
    void Start()
    {
        GameObject playerObj = Instantiate(playerPrefab, new Vector3(.56f, -.154f, 8.58f), Quaternion.identity);
        pc = playerObj.GetComponent<PlayerControllerTown>();
        playerObj.name = "player";
        if (playerObj.GetComponent<PlayerControllerRuins>().enabled == true)
        { playerObj.GetComponent<PlayerControllerRuins>().enabled = false;
            playerObj.GetComponent<PlayerControllerTown>().enabled = true; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 99999))
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("ground"))
                    {
                    ///if (hit.collider.gameObjectLayer == LayerMask.NameToLayer("ground"))
                    //GameObject starObj = Instantiate(starUnitPrefab, hit.point, Quaternion.identity);
                    //GameObject playerObj = Instantiate(playerPrefab, hit.point, Quaternion.identity);
                    Debug.Log(hit.point);
                    pc.SetTarget(hit.point); }
            }

        }
    }

}
