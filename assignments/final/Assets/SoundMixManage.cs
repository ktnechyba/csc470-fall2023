using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixManage : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetFXVolume(float level)
    {
        audioMixer.SetFloat("FXVolume", Mathf.Log10(level)*20);    }
    public void SetMusicVolume(float level)
    {
        audioMixer.SetFloat("musicVolume", Mathf.Log10(level) * 20);
    }
}
