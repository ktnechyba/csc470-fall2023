using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMenu : MonoBehaviour
{
    //public Animator animator;
    public void ButtonClicked()

    {
        //has button sound
    }
    public void StartButton()
    {
        SceneManager.LoadScene("Puzzle1");
        //animator.SetBool("P1", true);
    }

    //void SettingsButtonMenu()
    //{

    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
