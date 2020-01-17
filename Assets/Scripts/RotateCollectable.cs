using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectable : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(30, 15, 45) * Time.deltaTime);
    }
}