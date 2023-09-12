using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainGen : MonoBehaviour
{
    public GameObject TentPrefab;
    public GameObject mushroomPrefab;
    public GameObject tomatoSlicePrefab;
    public GameObject campfirePrefab;
    public GameObject asparagusPrefab;
    public GameObject flowersPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tentobj = Instantiate(TentPrefab, new Vector3(0.911f, 0.5897f, 1.843f), Quaternion.identity);
        GameObject fireobj = Instantiate(campfirePrefab, new Vector3(-.56f, .362f, 1.024807f), Quaternion.identity);
        for (int i = 0; i < 35; i++)
        {
            generateFlower();
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


    public void mushroomAroundPoint(int num, Vector3 point, float radius)
    {

        for (int i = 0; i < num; i++)
        {

            /* Distance around the circle */
            var radians = 2 * Mathf.PI / num * i;

            /* Get the vector direction */
            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);

            var spawnDir = new Vector3(horizontal, 0, vertical);

            /* Get the spawn position */
            var spawnPos = point + spawnDir * radius; // Radius is just the distance away from the point

            /* Now spawn */
            var enemy = Instantiate(mushroomPrefab, spawnPos, Quaternion.identity) as GameObject;

            /* Rotate the enemy to face towards player */
            enemy.transform.LookAt(point);

            /* Adjust height */
            enemy.transform.Translate(new Vector3(0, enemy.transform.localScale.y / 2, 0));
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
