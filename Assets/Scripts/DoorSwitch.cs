using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public GameObject Door;
    public bool Open;

    void Start()
    {
        Open = false;
    }

    void Update()
    {
        if (Open)
        {
            Door.SetActive(false);
        }
        else
        {
            Door.SetActive(true);
        }
    }

    public void Switch()
    {
        Open = !Open;
    }
}
