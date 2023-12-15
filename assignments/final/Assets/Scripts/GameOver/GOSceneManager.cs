using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOSceneManager : MonoBehaviour
{
    public Image fadeImage;

    void Start()
    {

        StartCoroutine(FadeIn());
        StartCoroutine(GameOver());

        //GameManager.sharedInstance.death = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FadeIn()
    {
        fadeImage.gameObject.SetActive(true);
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1);
        while (fadeImage.color.a > 0)
        {
            float newAlpha = fadeImage.color.a - 0.5f * Time.deltaTime;
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, newAlpha);
            yield return null;
        }
        fadeImage.gameObject.SetActive(false);
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("MainMenu");
    }


}
