using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;




public class PlayerCollection : MonoBehaviour
{
    //run to front of camera and jump! -> above, the collected items should appear with particle effects? or just FX
    public GameObject waypoint;
    public Animator animator;
    public Animator Text;
    bool win=false;
    bool fade = false;
    private float fixedDeltaTime;
    public TMP_Text completed;
    public TMP_Text lifeCount;
    public int life = 1;
    public int lives;
    [SerializeField] float speed = 1f;
    public int count = 0;


    void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;


    }
    private void Start()
    {
        count = PlayerPrefs.GetInt("count");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoint.transform.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, waypoint.transform.position) < .1f)
        {
            animator.SetBool("win", win = true);

            StartCoroutine(Freeze());
        }
    }

    IEnumerator Freeze()
    {

        yield return new WaitForSeconds(.5f);
        Text.SetBool("fade", fade = true);
        yield return new WaitForSeconds(.5f);
        Time.timeScale = 0.0f;
        //yield return new WaitForSeconds(1);
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("Puzzle3");




    }
    public void MainMen()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //IEnumerator FadeIn()
    //{
    //    completed.color = new Color(completed.color.r, completed.color.g, completed.color.b, 1);
    //    while (completed.color.a > 0)
    //    {
    //        float newAlpha = completed.color.a - 0.5f * Time.deltaTime;
    //        completed.color = new Color(completed.color.r, completed.color.g, completed.color.b, newAlpha);

    //    }

    //}
}
