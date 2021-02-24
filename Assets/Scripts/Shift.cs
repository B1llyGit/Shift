using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shift : MonoBehaviour
{
    private InputAction PlayerInput;

    public bool RedActive;
    public bool BlueActive;

    public Material BActive;
    public Material BInactive;
    public Material RActive;
    public Material RInactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnShift()
    {
        RedActive = !RedActive;
        BlueActive = !BlueActive;
        print("Lmao nice");
    }
}
