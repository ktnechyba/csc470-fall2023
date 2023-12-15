using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PuzzleGameManager : MonoBehaviour
{
    public Animator animator;
    public GameObject magic;
    public GameObject swordsman;
    // Start is called before the first frame update
    void Awake()
    {
        animator.SetBool("P1", true);
        if (CharacterSelect.shared_instance.mage == true)
        {
            magic.SetActive(true);
        }
        if (CharacterSelect.shared_instance.sword == true)
        {
            swordsman.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
