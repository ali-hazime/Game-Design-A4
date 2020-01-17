using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    public float speed;
    Vector3 respawn;
    bool safe;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawn = new Vector3(0, 0, 0);
        safe = false;
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void Update()
    {
        float jump;

        if (Input.GetKeyDown(KeyCode.Space))
            jump = 35f;
        else
            jump = 0;

        Vector3 movement = new Vector3(0, jump, 0);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Safe Zones"))
        {
            safe = true;
            print("Entered Safe Zone");
        }

        if (other.gameObject.CompareTag("Death Zone") && safe == false)
        {
            gameObject.transform.position = respawn;
            print("Entered Death Zone");
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Safe Zones"))
        {
            safe = false;
            print("Exited Safe Zone");
        }
    }
}

