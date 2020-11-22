using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionUpdate : MonoBehaviour
{
    private GameObject Controller;
    public bool Red;
    public Material Active;
    public Material Inactive;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GameObject.Find("Controller");
    }

    // Update is called once per frame
    void Update()
    {
        if (Red)
        {
            if (Controller.GetComponent<Shift>().RedActive)
            {
                GetComponent<Renderer>().material = Active;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                GetComponent<MeshRenderer>().receiveShadows = true;
                GetComponent<BoxCollider>().enabled = true;
            }
            if (!Controller.GetComponent<Shift>().RedActive)
            {
                GetComponent<Renderer>().material = Inactive;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                GetComponent<MeshRenderer>().receiveShadows = false;
                GetComponent<BoxCollider>().enabled = false;
            }
        }
        else
        {
            if (Controller.GetComponent<Shift>().BlueActive)
            {
                GetComponent<Renderer>().material = Active;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                GetComponent<MeshRenderer>().receiveShadows = true;
                GetComponent<BoxCollider>().enabled = true;
            }
            if (!Controller.GetComponent<Shift>().BlueActive)
            {
                GetComponent<Renderer>().material = Inactive;
                GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                GetComponent<MeshRenderer>().receiveShadows = false;
                GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
