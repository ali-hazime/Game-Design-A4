using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    //Rigidbody r;

    private void Start()
    {
        //r = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //r.AddTorque(new Vector3(13,0,0));
        transform.Rotate(new Vector3(13, 0, 0) * Time.deltaTime);
    }
}


