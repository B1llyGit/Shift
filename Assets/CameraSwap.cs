using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject IntroCameraControl;
    Animator SwapAnim;
    Animator PlayerAnim;

    public AudioSource soundPlayer;
    public AudioClip miss;
    public GameObject HUDPanel;

    // Start is called before the first frame update
    void Start()
    {
        SwapAnim = IntroCameraControl.GetComponent<Animator>();
        PlayerAnim = GetComponent<Animator>();
    }

    void CamSwap()
    {
        // Switches the camera, disables the "ThirdPersonPlayer" Animator and plays the attached sound.
        SwapAnim.SetBool("IntroCutscene", false);
        GetComponent<Animator>().enabled = false;
        soundPlayer.PlayOneShot(miss, 1.0F);
        HUDPanel.SetActive(true);
    }
}
