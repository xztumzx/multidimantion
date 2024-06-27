using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
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

   /*public void Loadgame()
    {
        SceneManager.LoadScene("noey3");
    }

    public void NewGame() 
    {
        SceneManager.LoadScene("home");
    }

    public void Setting()
    {
        SceneManager.LoadScene("test");
    }

    public void Exit()
    {
        Application.Quit();
    }*/
}