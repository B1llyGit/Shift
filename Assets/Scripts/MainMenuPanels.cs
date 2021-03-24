using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanels : MonoBehaviour

{

    //Main Menu Panels

    public GameObject mainPanel;
    private bool mainPanelOn = true;

    public GameObject optionsPanel;
    private bool optionsPanelOn = false;

    public GameObject levelPanel;
    private bool levelPanelOn = false;


    private void Start()
    {

        mainPanel.SetActive(true);
        optionsPanel.SetActive(false);
        levelPanel.SetActive(false);

    }



    public void mainToggle()
    {
        if (mainPanelOn == false)
        {
            mainPanel.SetActive(true);
        }
        else
        {
            mainPanel.SetActive(false);
        }

        mainPanelOn = !mainPanelOn;

    }


    public void optionsToggle()
    {
        if (optionsPanelOn == false)
        {
            optionsPanel.SetActive(true);
        }
        else
        {
            optionsPanel.SetActive(false);
        }

        optionsPanelOn = !optionsPanelOn;

    }


    public void levelToggle()
    {
        if (levelPanelOn == false)
        {
            levelPanel.SetActive(true);
        }
        else
        {
            levelPanel.SetActive(false);
        }

        levelPanelOn = !levelPanelOn;

    }





}
