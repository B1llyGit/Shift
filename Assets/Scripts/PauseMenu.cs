using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{


    public static bool GameIsPaused = false;
    public string newGameLevel;
    public GameObject pauseMenuUI;

    private void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (GameIsPaused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Resume();

            }

            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Pause();

            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()

    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }


    public void LoadMenu()

    {
        Time.timeScale = 1f;
        Debug.Log("loading menu");
        SceneManager.LoadScene(newGameLevel);

    }

        public void QuitGame()
    {
        Debug.Log("Quiting Game");
        Application.Quit();
     }
}



