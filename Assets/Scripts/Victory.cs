using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public Material lightGreen;

    void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material = lightGreen;
        print("Victory!");
    }
}