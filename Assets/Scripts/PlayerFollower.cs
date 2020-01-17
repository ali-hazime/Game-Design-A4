using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    private Vector3 camOffset;
    public GameObject sphere;

    void Start()
    {
        camOffset = new Vector3(0, 10, -10);
    }

    void LateUpdate()
    {
        transform.position = sphere.transform.position + camOffset;
    }

}
