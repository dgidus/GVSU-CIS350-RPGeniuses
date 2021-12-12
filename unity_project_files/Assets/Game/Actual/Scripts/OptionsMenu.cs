using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetMusicVolume (float musicvolume)
    {
        audioMixer.SetFloat("musicvolume", musicvolume);
    }

    public void SetGameVolume (float ambientvolume)
    {
        audioMixer.SetFloat("ambientvolume", ambientvolume);
    }
}
