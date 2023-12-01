using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOSceneManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GameOver());
        //GameManager.sharedInstance.death = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
