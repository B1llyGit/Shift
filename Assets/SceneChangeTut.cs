using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTut : MonoBehaviour
{

    public void ChangeScene()
    {
        
        SceneManager.LoadScene("TutorialV3"); //NEEDS TO CHANGE WHEN FINAL SCENE NAME CHANGES
        
    }
}
