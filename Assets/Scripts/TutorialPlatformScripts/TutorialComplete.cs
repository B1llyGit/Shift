using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialComplete : MonoBehaviour
{
    public GameObject theTrigg;

    public AudioSource soundPlayer;

    public AudioClip miss;
    public AudioClip miss2;
    public GameObject CompletePanel;

    public bool PanelOpen = false;

    void Start()
    {
        CompletePanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            theTrigg.SetActive(false);
            soundPlayer.PlayOneShot(miss, 1.0F);
            CompletePanel.SetActive(true);
            PanelOpen = true;
        }
    }


    public void ClosePanel()
    {
        CompletePanel.SetActive(false);
        PanelOpen = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        soundPlayer.PlayOneShot(miss2, 1.0F);
    }

    void Update()
    {
        if (PanelOpen == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }


    }
}

