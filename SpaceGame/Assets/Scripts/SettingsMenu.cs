using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer sfxMixer;

    public GameObject menu;

    public void SetMusicVolume (float musicVolume)
    {
        musicMixer.SetFloat("musicVolume", musicVolume);
    }

    public void SetSFXVolume (float sfxVolume)
    {
        sfxMixer.SetFloat("sfxVolume", sfxVolume);
    }

    public void BackButtonClick()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);

    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
