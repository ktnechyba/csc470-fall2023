using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Puzzle3Manager : MonoBehaviour
{

    public Camera cam;
    public GameObject magic;
    public GameObject swordsman;

    private void Awake()
    {
        if (CharacterSelect.shared_instance.mage == true)
        {
            magic.SetActive(true);
        }
        if (CharacterSelect.shared_instance.sword == true)
        {
            swordsman.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                GameObject.FindGameObjectWithTag("cube").GetComponent<Puzzle3CC>();

            }
        }
    }
    public void MainMen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
