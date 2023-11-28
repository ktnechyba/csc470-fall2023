using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsEffectsManager : MonoBehaviour
{
    public static SoundsEffectsManager instance;

    [SerializeField] private AudioSource soundFXobject;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySoundFX(AudioClip audioClip, Transform loc, float volume)
    {
        AudioSource audioSource = Instantiate(soundFXobject, loc.position, Quaternion.identity);

        audioSource.clip = audioClip;

        audioSource.volume = volume;

        audioSource.Play();

        float soundLength = audioSource.clip.length;



    }
}
