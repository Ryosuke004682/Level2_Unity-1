using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    Rigidbody rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0.0f,0.0f,-10.0f) ;
    
        if(transform.position.z < -42.0f)
        {
            rb.velocity *= 0;
        }
    }
}
