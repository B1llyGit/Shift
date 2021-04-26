using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject theTrigg;



 
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

