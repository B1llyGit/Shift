﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}