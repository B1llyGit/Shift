using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeLevel1 : MonoBehaviour
{
    Animator MyAnim;
    // Start is called before the first frame update
    void Start()
    {
        MyAnim.Rebind();
        MyAnim.Update(0f);
    }

    public void ChangeScene()
    {
        
        SceneManager.LoadScene("Level1V7"); //NEEDS TO CHANGE WHEN FINAL SCENE NAME CHANGES
        MyAnim.Play("Loading 2", -1, 0f);
    }
}
