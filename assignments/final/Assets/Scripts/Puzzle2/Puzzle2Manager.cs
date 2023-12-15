using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Puzzle2Manager : MonoBehaviour
{
    public TMP_Text lifeCount;
    private void Update()
    {
        lifeCount.text = "x2";
    }
    public void MainMen()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
