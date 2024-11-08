using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rover_Controller : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(rb.transform.forward * 7);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(rb.transform.forward * -7);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(Vector3.down, .5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(Vector3.up, .5f);
        }
    }
}
