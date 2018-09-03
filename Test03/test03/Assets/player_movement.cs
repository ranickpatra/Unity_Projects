using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

	public Rigidbody rb;
	private float vx=0f, vy=0f, vz=4000f;
	private bool clicked = false;


	// Use this for initialization
	void Start () {


	}


	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			clicked = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		if(clicked)
			rb.AddForce(vx*Time.deltaTime, vy*Time.deltaTime, vz*Time.deltaTime);

		if(Input.GetKey("a")) {
			rb.AddForce (-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		} else if (Input.GetKey("d")) {
			rb.AddForce (50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		

	}
}
