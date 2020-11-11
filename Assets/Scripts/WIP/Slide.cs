using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    Rigidbody rig;
    public CharacterController controller;

    float originalHeight;
    public float reducedHeight;

    public float slideSpeed = 10f;

    bool isSliding;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rig = GetComponent<Rigidbody>();
        originalHeight = controller.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKey(KeyCode.W))
            Sliding();
        else if (Input.GetKeyUp(KeyCode.LeftControl))
            GoUp();
    }


    private void Sliding()
    {
        controller.height = reducedHeight;
        rig.AddForce(transform.forward * slideSpeed, ForceMode.VelocityChange);
    }

    private void GoUp()
    {
        controller.height = originalHeight;
    }
}
