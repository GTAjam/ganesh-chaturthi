using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nnn : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 500f;
    private void Start()
    {
        rb.AddForce(0, 0, 0);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.z <= 568)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            if (Input.GetKey("d"))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (rb.position.y <= -1 || rb.position.x <= -7.7 || rb.position.x >= 7.7)
            {
                FindObjectOfType<Manager>().Endgame();
            }
        }
    }
}
