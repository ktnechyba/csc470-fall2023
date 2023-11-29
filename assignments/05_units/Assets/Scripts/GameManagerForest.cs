using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerForest : MonoBehaviour
{
    public GameObject playerPrefab;
    // Start is called before the first frame update

    void Start()
    {
        GameObject playerObj = Instantiate(playerPrefab, new Vector3(147.38f, 0, -292.8349f), Quaternion.identity);
        playerObj.name = "player";
        playerObj.GetComponent<PlayerControllerTown>().enabled = false;
        playerObj.GetComponent<PlayerControllerRuins>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
