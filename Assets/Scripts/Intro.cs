using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{

    public GameObject PodSmoke;
    public GameObject ThePlayer;

    Animator PlayerAnim;
    // Start is called before the first frame update
    void Start()
    {
        //ThePlayer.GetComponent<Animator>();
        PlayerAnim = ThePlayer.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void animtrigger()
    {
        PodSmoke.GetComponent<ParticleSystem>().Play();
        PlayerAnim.SetBool("Move", true);
    }
}
