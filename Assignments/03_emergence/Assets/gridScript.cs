using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridScript : MonoBehaviour
{
    public GameObject gridBasePrefab;
    gridBaseScript[,] gridBase;

    // Start is called before the first frame update
    void Start()
    {
        //new 2d array
        gridBase = new gridBaseScript[10,10];

        //nested for loops
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                //create position
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
