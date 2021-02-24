using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{

    public void ChangeScene(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game");
        Application.Quit();
    }
}
