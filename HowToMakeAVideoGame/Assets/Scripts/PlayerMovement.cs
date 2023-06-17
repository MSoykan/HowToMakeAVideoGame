using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysFloat = 200;
    private float forceValue;
    int i;
    private void Start() {
        i = 0;
        rb.AddForce(0, 200, 500);
    }

    //private void Update() {
    //    rb.AddForce(0, 0, 200 * Time.deltaTime) ;
    //}
    private void Update() {
        //    if (Input.GetKey("d")) {
        //        rb.AddForce(sideWaysFloat * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //    }
        //    if (Input.GetKey("a")) {
        //        rb.AddForce(-sideWaysFloat * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //    }
    }

    //If we are adding forces or changing velocity(doing Physics stuff) do it inside the ***FixedUpdate***
    private void FixedUpdate() {
        //Add a force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //transform.position = new Vector3( Mathf.Clamp(transform.position.x, -7, 7),transform.position.y ,transform.position.z );
        
        if (Input.GetKey("d")) {
            rb.AddForce(sideWaysFloat * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("I value:" + i);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sideWaysFloat * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Debug.Log("I value:" + i);
        }

        //float x = Input.GetAxisRaw("Horizontal");
        //rb.AddForce(x * 200 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
