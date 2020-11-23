using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour
{
    public bool RedActive;
    public bool BlueActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shift"))
        {
            RedActive = !RedActive;
            BlueActive = !BlueActive;
            print("Lmao nice");
        }
    }
}
