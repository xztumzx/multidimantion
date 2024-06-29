using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SoundScript : MonoBehaviour
{
    [Header("Volume Setting")]
    /*[SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 1.0f;*/

    [SerializeField] private AudioMixer myMixer;

    [SerializeField] private Slider musicSlider;
    [SerializeField] private TMP_Text musicTextValue = null;
    [SerializeField] private float musicDefaultVolume = 1.0f;

    [SerializeField] private Slider SFXSlider;
    [SerializeField] private TMP_Text SFXTextValue = null;
    [SerializeField] private float SFXDefaultVolume = 1.0f;

    [SerializeField] private GameObject comfirmationPrompt = null;

    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
       
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
        musicTextValue.text = volume.ToString("0.0");
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
        SFXTextValue.text = volume.ToString("0.0");
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        SetMusicVolume();
        SetSFXVolume();
    }

    /*public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = volume.ToString("0.0");
    }*/

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }

    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            AudioListener.volume = musicDefaultVolume;
            AudioListener.volume = SFXDefaultVolume;
            musicSlider.value = musicDefaultVolume;
            musicTextValue.text = musicDefaultVolume.ToString("0.0");
            SFXSlider.value = SFXDefaultVolume;
            SFXTextValue.text = SFXDefaultVolume.ToString("0.0");
            VolumeApply();
        }
    }
    public IEnumerator ConfirmationBox()
    {
        comfirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        comfirmationPrompt.SetActive(false);
    }
}
