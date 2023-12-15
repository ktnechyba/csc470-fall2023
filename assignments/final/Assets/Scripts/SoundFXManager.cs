using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public SoundFXManager instance;
    public AudioSource soundFXobject;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //public void PlaySoundFXClip(AudioClip audioClip)

}
