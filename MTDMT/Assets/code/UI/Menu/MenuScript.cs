using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    /*[Header("Volume Setting")]
    [SerializeField] private TMP_Text volumeTeextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 1.0f;

    [SerializeField] private GameObject comfirmationPrompt = null;*/


    [Header("Levels To Load")]
    //public string _newGameStory;
    private string storyToLoad;
    [SerializeField] private GameObject noSaveGameDialog = null;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene("noey3");
    }

    public void LoadGameDialogYes()
    {
        if (PlayerPrefs.HasKey("SaveStory"))
        {
            storyToLoad = PlayerPrefs.GetString("SaveStory");
            // PlayerPrefs.SetString("SaveLevel", yourstoryis); => keep save the game
            SceneManager.LoadScene(storyToLoad);
        }
        else
        {
            noSaveGameDialog.SetActive(true);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    /*public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTeextValue.text = volume.ToString("0.0");
    }

    public void VolumeApple()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox()); 
    }

    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeTeextValue.text = defaultVolume.ToString("0.0");
            VolumeApple();
        }
    }

    public IEnumerator ConfirmationBox()
    {
        comfirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        comfirmationPrompt.SetActive(false);
    }*/

}