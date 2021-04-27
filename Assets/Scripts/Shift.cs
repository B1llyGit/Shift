using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shift : MonoBehaviour
{
    private InputAction PlayerInput;

    public GameObject RedPanel;
    public GameObject BluePanel;

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

    private void Update()
    {
       if (RedActive == true)
        {
            RedPanel.SetActive(true);
            BluePanel.SetActive(false);
        }

       else if (BlueActive == true)
        {
            RedPanel.SetActive(false);
            BluePanel.SetActive(true);
        }
    }



    public void OnShift()
    {
        RedActive = !RedActive;
        BlueActive = !BlueActive;
        print("Lmao nice");
        
    }
}
