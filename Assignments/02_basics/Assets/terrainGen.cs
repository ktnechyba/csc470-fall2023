using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class terrainGen : MonoBehaviour
{
    public GameObject TentPrefab;
    public GameObject tomatoSlicePrefab;
    public GameObject campfirePrefab;
    public GameObject asparagusPrefab;
    public GameObject flowersPrefab;
    public GameObject mushroomPrefab;
    public GameObject ballPrefab;
    public GameObject bigTomatoesPrefab;
    public float xfact = 0;
    public float zfact = 0;
    public float spacing = .05f;


    // Start is called before the first frame update
    void Start()
    {
        GameObject tentobj = Instantiate(TentPrefab, new Vector3(0.911f, 0.5897f, 1.843f), Quaternion.identity);
        GameObject fireobj = Instantiate(campfirePrefab, new Vector3(-.69f, .362f, 1.4f), Quaternion.identity);
        
        for (int i = 0; i < 35; i++)
        {
            generateFlower();
        }

        for (int i = 0; i < 10; i++)
        {
            generateMushrooms();
        }


    }


    void generateFlower()
    {
        float x = Random.Range(-1.8f, 1.87f);
        float y = 0.277f;
        float z = Random.Range(-2.5987f, -.37f);
        Vector3 pos = new Vector3(x, y, z);
        GameObject treeObj = Instantiate(flowersPrefab, pos, Quaternion.identity);
    }
    void generateMushrooms()
    {
        float x = 0.35f+xfact;
        float y = 0.275f;
        float z = 1.5f+zfact;
        Vector3 pos = new Vector3(x, y, z);
        GameObject treeObj = Instantiate(mushroomPrefab, pos, Quaternion.identity);
        xfact -= .2f;
        zfact -= .195f;
    }
        // Update is called once per frame
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ba = Instantiate(ballPrefab, new Vector3(-4.429f, 1.976f, 0.055f), Quaternion.identity);

        }
    }


}
