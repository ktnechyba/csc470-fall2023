using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Puzzle2Manager : MonoBehaviour
{
    public static Puzzle2Manager sharedInstance;
    public List<ClickOn> units = new List<ClickOn>();

    public GameObject platformPrefab;

    ClickOn selectedUnit;

    // Start is called before the first frame update
    void Awake()
    {
         sharedInstance = this;

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 999999))
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("ground"))
                {
                    // If we get in here, we hit something! And the 'hit' object
                    // contains info about what we hit.
                    //if (selectedUnit != null)
                    //{
                    //    selectedUnit.SetTarget(hit.point);
                    //}
                }
            }
        }
    }
}
