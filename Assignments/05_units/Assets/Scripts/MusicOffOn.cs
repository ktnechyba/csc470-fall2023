using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOffOn : MonoBehaviour
{
    [SerializeField] private Sprite[] musicSprites;
    [SerializeField] private Image targetSprite;
    [SerializeField] private bool hasBeenClicked = false;
    public void Toggle()
    {
        if (targetSprite.sprite == musicSprites[0] && hasBeenClicked ==false)
        {
            targetSprite.sprite = musicSprites[1];
            hasBeenClicked = true;
        }

        else if (hasBeenClicked == true && targetSprite.sprite == musicSprites[1])
        {
            targetSprite.sprite = musicSprites[0];
            hasBeenClicked = false;
        }
    }
}
