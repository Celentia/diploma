using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    CursorLockMode desiredMode;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !DialogueManager.GetInstance().dialogueIsPlaying) 
        {
            if (GameIsPaused) 
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;                 
        Cursor.visible = false;
        desiredMode = CursorLockMode.Confined;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        desiredMode = CursorLockMode.None;
        {
            Cursor.lockState = desiredMode;
        }
    }

    public void LoadMenu() 
    {
        SceneManager.LoadScene("Menu"); 
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
