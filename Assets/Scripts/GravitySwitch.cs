using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    private Vector3 InitGravity;
    public Vector3 NewGravity;
    private Vector3 Gravity;
    private GameObject Player;
    public float Seconds;

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
        Player.GetComponent<ThirdPersonMovement>().floating = true;
        print(Physics.gravity);
        yield return new WaitForSeconds(Seconds);
        Physics.gravity = InitGravity;
        Gravity = InitGravity;
        Player.GetComponent<ThirdPersonMovement>().gravity = Gravity.y;
        Player.GetComponent<ThirdPersonMovement>().floating = false;
    }
}
