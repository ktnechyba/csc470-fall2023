using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gridBaseScript : MonoBehaviour
{
    public bool isAlive = false;
    public Color aliveColor;
    public Color deadColor;

    public int aliveNeighbors = 0;

    public int x = -1;
    public int z = -1;

    public int id;
    public gridScript parentGen;
    gridScript gsO;

    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {


        rend = gameObject.GetComponentInChildren<Renderer>();
        ColorUp();

    }

    public void ColorUp()
    {
        if (isAlive)
        {
            rend.material.color = aliveColor;
        }
        else
        {
            rend.material.color = deadColor;
        }
    }

    public void SetAlive(bool alive)
    {
        isAlive = alive;
        if (isAlive)
        {
            rend.material.color = aliveColor;
        }
        else
        {
            rend.material.color = deadColor;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("arrow"))
        {
            isAlive = true;
            if (isAlive)
            {
                isAlive = false;
                rend.material.color = deadColor;
            }
            else
            {
                isAlive = true;
                rend.material.color = aliveColor;
            }

        }
    }
}
