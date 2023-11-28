using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOffOn : MonoBehaviour
{
    [SerializeField] private Sprite[] musicSprites;
    [SerializeField] private Image targetSprite;
    [SerializeField] private bool muted = false;
    void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
        }
        else
        {
            Load();
        }
    }

    public void Toggle()
    {
        if (targetSprite.sprite == musicSprites[0] && muted ==false)
        {
            targetSprite.sprite = musicSprites[1];
            muted = true;
            AudioListener.pause = true;
        }

        else if (muted == true && targetSprite.sprite == musicSprites[1])
        {
            targetSprite.sprite = musicSprites[0];
            muted = false;
            AudioListener.pause = false;
        }
        Save();
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);

    }

}
