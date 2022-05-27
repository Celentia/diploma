using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        Cursor.visible = true;

        if (PlayerPrefs.HasKey("LevelSaved") == false)
        {
            button = GameObject.Find("LoadButton").GetComponent<Button>();
            button.interactable = false;
        }
    }

    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGame()
    {
        string levelToLoad = PlayerPrefs.GetString("LevelSaved");
        SceneManager.LoadScene(levelToLoad);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
