using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createLayout : MonoBehaviour
{
    public GameObject logsPrefab;
    public GameObject collaredPeccaryPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = Instantiate(collaredPeccaryPrefab, new Vector3(-4.647161f, 0, 13.46f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Random.Range(4, 2);
        //float y = 2.3f;
        //float z = 6.2;
        //Vector3 pos = new Vector3(x, y, z);
        //GameObject logs = Instantiate(logsPrefab, pos, Quaternion.identity);
    }
}
