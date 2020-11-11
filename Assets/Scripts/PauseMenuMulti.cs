using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenuMulti : MonoBehaviour
{


    public GameObject objectWithMouseLookScript;
    public static bool GameIsPaused = false;
    public string loadLevel;
    public GameObject pausePanel = null;
    public GameObject Panel2 = null;
    public GameObject Panel3 = null;
    public GameObject quitPanel = null;

    public GameObject inspectionObject = null;


    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Escape))
        {

            ////if the game is paused
            if (GameIsPaused == true)
            {

                
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Resume();


            }
            ////if game is not paused
            else
            {
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                DisplayPauseOnly();


            }
        }

        if (Time.timeScale == 1f)
        {
           
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

    }



    public void Resume()
    {
        
        
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        objectWithMouseLookScript.GetComponent<FirstPersonController>().enabled = true;
        Panel2.SetActive(false);
        pausePanel.SetActive(false);
        quitPanel.SetActive(false);
        Panel3.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        


    }

    public void DisplayPauseOnly()

    {
        inspectionObject.SetActive(false);
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        objectWithMouseLookScript.GetComponent<FirstPersonController>().enabled = false;
        Panel2.SetActive(false);
        quitPanel.SetActive(false);
        Panel3.SetActive(false);
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }


    public void DisplayPanel2Only()

    {
       
        objectWithMouseLookScript.GetComponent<FirstPersonController>().enabled = false;
        Panel2.SetActive(true);
        quitPanel.SetActive(false);
        Panel3.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    
    
    }

    public void DisplayPanel3Only()
    {
        objectWithMouseLookScript.GetComponent<FirstPersonController>().enabled = false;
        Panel2.SetActive(false);
        quitPanel.SetActive(false);
        pausePanel.SetActive(false);
        Panel3.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    public void DisplayQuitOnly()
    {
        
        objectWithMouseLookScript.GetComponent<FirstPersonController>().enabled = false;
        quitPanel.SetActive(true);
        pausePanel.SetActive(false);
        Panel3.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()

    {
        Time.timeScale = 1f;
        Debug.Log("loading menu");
        SceneManager.LoadScene(loadLevel);

    }

        public void QuitGame()
    {
        Debug.Log("Quiting Game");
        Application.Quit();

   }


}



