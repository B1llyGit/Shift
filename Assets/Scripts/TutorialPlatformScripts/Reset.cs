﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fog")
        {
            gameObject.transform.position = originalPos;
        }

    }
}