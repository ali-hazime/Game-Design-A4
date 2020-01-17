using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDeathZone : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
    }
}
