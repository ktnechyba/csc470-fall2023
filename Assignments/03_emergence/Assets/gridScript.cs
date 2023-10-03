using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridScript : MonoBehaviour
{
    public GameObject gridBasePrefab;
    public GameObject aliveBPrefab;
    public GameObject deadBPrefab;
    public gridBaseScript[,] gridBase;
    public int x = -1;
    public int z = -1;
    gridBaseScript gBS;
    //int num = 0;

    // Start is called before the first frame update
    void Start()
    {
 

        //new 2d array
        gridBase = new gridBaseScript[10, 10];
        //int idCount = 0;

        //nested for loops
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                //create position
                Vector3 pos = transform.position;
 
                float spacing = 1.035f;
                pos.x = pos.x + x * ( spacing);
                pos.z = pos.z + z * (spacing);
                GameObject gridCellObj = Instantiate(gridBasePrefab, pos, transform.rotation);

                //store script on gridBase
                gridBase[x, z] = gridCellObj.GetComponent<gridBaseScript>();
                //assign alive or dead randomly at start
                gridBase[x, z].x = x;
                gridBase[x, z].z = z;
                gridBase[x, z].isAlive = (Random.value < 0.46f);



                //assign id number to each gridBase clone
                //gridCellObj.GetComponent<gridBaseScript>().id = idCount;
                //gridCellObj.GetComponent<gridBaseScript>().parentGen = this;
                //idCount += 1;


            }


        }
        Balloons();
        gBS = GameObject.FindGameObjectWithTag("cellBase").GetComponent<gridBaseScript>();


        //use the ids created to do the finding alive nieghbors -> if statements about location to not go out of bounds on each side

    }
    /// <summary>
    /// top left = gridBase[x-1, z-1].isAlive
    /// top middle = gridBase[x-1, z].isAlive
    /// top right = gridbase[x-1, z+1].isAlive
    /// middle left = gridBase[x, z-1].isAlive
    /// middle right = gridBase[x, z+1].isAlive
    /// bottom left = gridBase[x+1, z-1].isAlive
    /// bottom middle = gridBase[x+1, z].isAlive
    /// bottom right = gridBase[x+1, z+1].isAlive
    /// </summary>
    void NeighborEx()
    {
        //int num = 0;
        //aliveCount.Clear();
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                int aliveNeighbors = 0;
                if (x == 0 && z == 0)
                {
                    if (gridBase[x, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num,aliveNeighbors);
                    //////num += 1;

                }
                else if (x == 9 && z == 0)
                {
                    if (gridBase[x, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else if (x == 0 && z == 9)
                {
                    if (gridBase[x, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }

                    if (gridBase[x + 1, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else if (x == 9 && z == 9)
                {
                    if (gridBase[x, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else if (z == 0)
                {
                    if (gridBase[x-1, z ].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x-1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x, z+1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else if (x == 0)
                {
                    if (gridBase[x, z-1].isAlive)
                    {
                        aliveNeighbors++;
                    }

                    if (gridBase[x, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z].isAlive)
                    { aliveNeighbors++; }

                    if (gridBase[x + 1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x+1, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }

                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else if (x == 9)
                {
                    if (gridBase[x - 1, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z].isAlive)
                    {
                        aliveNeighbors++;

                    }
                    if (gridBase[x-1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x, z+1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else if (z == 9)
                {
                    if (gridBase[x - 1, z-1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x, z-1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x+1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x+1, z-1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                else
                {
                    if (gridBase[x - 1, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x - 1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z - 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    if (gridBase[x + 1, z].isAlive)
                    {
                        aliveNeighbors++;

                    }
                    if (gridBase[x + 1, z + 1].isAlive)
                    {
                        aliveNeighbors++;
                    }
                    
                    //aliveCount.Add(num, aliveNeighbors);
                    //////num += 1;
                }
                gridBase[x, z].aliveNeighbors = aliveNeighbors;
            }
        }
    }



    void Implement()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                if (gridBase[x, z].isAlive)
                {
                    if (gridBase[x, z].aliveNeighbors != 2 && gridBase[x, z].aliveNeighbors != 3)
                    {
                        gridBase[x, z].SetAlive(false);
                        gBS.ColorUp();


                    }
                    else
                    {
                        if (gridBase[x, z].aliveNeighbors == 3)
                        {
                            gridBase[x, z].SetAlive(true);
                            gBS.ColorUp();


                        }
                    }

                }


            }
        }
    }

    void Balloons()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                if (gridBase[x, z].isAlive)
                {
                    Vector3 pos = new Vector3(0, 0, 0);

                    float spacing = 1.035f;
                    pos.x = pos.x + x * (spacing);
                    pos.z = pos.z + z * (spacing);
                    pos.y = pos.y + 1.3f;
                    GameObject aliveBObj = Instantiate(aliveBPrefab, pos, transform.rotation);
                }
                else
                {
                    Vector3 pos = new Vector3(0, 0, 0);
                    float spacing = 1.035f;
                    pos.x = pos.x + x * (spacing);
                    pos.z = pos.z + z * (spacing);
                    pos.y = pos.y + 1.3f;
                    GameObject deadBObj = Instantiate(deadBPrefab, pos, transform.rotation);
                }

            }
        }

    }

    // Update is called once per frame
    void Update()
        {

        //if space bar pressed -go through the rules of the Game of Life and execute them
        if (Input.GetKeyDown(KeyCode.Space))
        {

            NeighborEx();
            Implement();
            Balloons();
        }
    }
}

