using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public static CharacterSelect shared_instance;

    public bool mage = false;
    public bool sword = false;
    [SerializeField] bool check = true;
    // Start is called before the first frame update
    void Awake()
    {
        shared_instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == false)
        {
            mage = false;
            sword = false;
        }
    }
    public void ChooseMage()
    {
        mage = true;
        sword = false;
        check = true;
    }
    public void ChooseSword()
    {
        sword = true;
        mage = false;
        check = true;
    }
    public void Check()
    {
        check = false;
    }
    public void Puzzle1()
    {
        SceneManager.LoadScene("Puzzle1");

    }
}
