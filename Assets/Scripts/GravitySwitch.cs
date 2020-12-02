using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    private Vector3 InitGravity;
    public Vector3 NewGravity;
    private Vector3 Gravity;
    private GameObject Player;

    void Start()
    {
        InitGravity = Physics.gravity;
        Gravity = InitGravity;
        Player = GameObject.Find("Third Person Player");
        print(InitGravity);
        print(NewGravity);
        print(Gravity);
    }

    void Update()
    {

    }

    public void Switch()
    {
        StartCoroutine(ChangeGravity());
    }

    IEnumerator ChangeGravity()
    {
        print("Gravity hath shifted");
        Physics.gravity = NewGravity;
        Gravity = NewGravity;
        Player.GetComponent<ThirdPersonMovement>().gravity = Gravity.y;
        //Player.GetComponent<ThirdPersonMovement>().isGrounded = false;
        print(Physics.gravity);
        yield return new WaitForSeconds(1.5f);
        Physics.gravity = InitGravity;
        Gravity = InitGravity;
        Player.GetComponent<ThirdPersonMovement>().gravity = Gravity.y;
    }
}
