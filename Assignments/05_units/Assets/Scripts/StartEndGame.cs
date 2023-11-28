using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEndGame : MonoBehaviour
{
    public string sceneName;
    [SerializeField] private AudioClip selected;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void ButtonSelected()
    {
        SoundsEffectsManager.instance.PlaySoundFX(selected, transform, 1f);
    }
}
