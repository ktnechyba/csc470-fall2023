using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class flowerTriggers : MonoBehaviour
{
    public GameObject pink;
    public GameObject buttonBlock;
    public bool hit = false;
    Renderer rend;
    public Material change;
    // Start is called before the first frame update
    void Awake()
    {
        rend = gameObject.GetComponentInChildren<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cube") && gameObject.CompareTag("button1"))
        {
            pink.SetActive(true);
            rend.sharedMaterial = change;
            hit = true;
        }
        if(other.CompareTag("Player") && gameObject.CompareTag("portal"))
        {
            SceneManager.LoadScene("GameOver");
        }
        if (other.CompareTag("Player") && gameObject.CompareTag("button2"))
        {
            buttonBlock.SetActive(true);
            rend.sharedMaterial = change;
        }
        if (other.CompareTag("player") && gameObject.CompareTag("portal"))
        {
            SceneManager.LoadScene("GameOver");
        }
        if (other.CompareTag("player") && gameObject.CompareTag("button2"))
        {
            buttonBlock.SetActive(true);
            rend.sharedMaterial = change;
        }
    }
}
