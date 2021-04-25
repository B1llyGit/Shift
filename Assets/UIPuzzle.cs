using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPuzzle : MonoBehaviour
{
    public GameObject InteractUI;
    public GameObject PuzzleCameraControl;
    public GameObject PuzzlePanel;
    Animator SwapAnim;
    public GameObject Player;
    CharacterController PlayerCont;


    public bool PlayingPuzzle = false;
    public bool colliding;
  
 

    public void Start()
    {
        SwapAnim = PuzzleCameraControl.GetComponent<Animator>();
        InteractUI.SetActive(false);
        colliding = false;
        PlayerCont = Player.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            if (PlayingPuzzle == false)
            {
                CameraSwap();
                
            }

            else if (PlayingPuzzle == true)
            {
                CameraSwapBack();
            }
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractUI.SetActive(true);
            colliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractUI.SetActive(false);
            colliding = false;
        }
    }

    void CameraSwap()
    {
        //Switches the cameras, freezes the player so they cant move
        SwapAnim.SetBool("PlayingPuzzle", true);
        PuzzlePanel.SetActive(true);
        PlayerCont.enabled = false;
        PlayingPuzzle = true;
        InteractUI.SetActive(false);

    }

    void CameraSwapBack()
    {
        //Switches the Cameras Back, 
        SwapAnim.SetBool("PlayingPuzzle", false);
        PuzzlePanel.SetActive(false);
        PlayerCont.enabled = true;
        PlayingPuzzle = false;
        InteractUI.SetActive(true);
    }

}