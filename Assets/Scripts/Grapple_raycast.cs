using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapple_raycast : MonoBehaviour
{
    public GameObject indicate;
    public Material rend;
    void Start()
    {
        rend = indicate.GetComponent<Renderer>().material;
    }


    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, 50))
        {
            rend.SetColor("_Color", Color.green);
        }
        else
        {
            rend.SetColor("_Color", Color.red);
        }
    }
}
