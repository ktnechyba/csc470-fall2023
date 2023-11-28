using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameOver());
        GameManager.sharedInstance.death = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}
