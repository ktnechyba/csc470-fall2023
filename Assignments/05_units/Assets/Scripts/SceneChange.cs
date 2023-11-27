using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name == "WorldTown") SceneManager.LoadScene("ForestRuins", LoadSceneMode.Single);
            else if (SceneManager.GetActiveScene().name == "ForestRuins") SceneManager.LoadScene("WorldTown", LoadSceneMode.Single);
        }
    }
}
