using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEvent : MonoBehaviour
{

    public GameObject soupPrefab;
    public GameObject knifePrefab;
    public GameObject bigTomatoes;
    public GameObject slicedTomatoesPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("spawnObj", 1);

        }
   
    }

    void spawnObj()
    {
        GameObject soupObj = Instantiate(soupPrefab, new Vector3(0.06800604f, 1.683f, -1.658816f), Quaternion.identity);
        GameObject knifeObj = Instantiate(knifePrefab, new Vector3(1.378176f, 1.683f, -1.408534f), Quaternion.identity);
       
        GameObject sliceTomobj = Instantiate(slicedTomatoesPrefab, new Vector3(0, .278f, 0f), Quaternion.identity);
    }

// Update is called once per frame
void Update()
    {
        
    }
}
