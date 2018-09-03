using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;
    private float vx=0f, vy=0f, vz=500f;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(vx*Time.deltaTime, vy*Time.deltaTime, vz*Time.deltaTime);
        //rb.AddForce(0, 0, 200);

    }
}
