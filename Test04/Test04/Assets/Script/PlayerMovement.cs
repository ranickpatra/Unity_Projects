using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rigidBodyPlayer;
	private Vector3 right_move = new Vector3(5, 0, 0), 
					left_move = new Vector3(-5, 0, 0), 
					stop_move = new Vector3(0, 0, 0);
	private bool hit_obstracle = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!hit_obstracle) {
			if (Input.GetKey ("a")) {
				rigidBodyPlayer.velocity = left_move;
			} else if (Input.GetKey ("d")) {
				rigidBodyPlayer.velocity = right_move;
			} else {
				rigidBodyPlayer.velocity = stop_move;
			}
		}
		
	}

	void FixedUpdate() {
		if (!hit_obstracle) {
			rigidBodyPlayer.AddForce (0, 0, 250 * Time.deltaTime, ForceMode.VelocityChange);
		}
		
	}



	void OnCollisionEnter(Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstracle") {
			this.enabled = false;
			if(!hit_obstracle)
				rigidBodyPlayer.AddForce(collisionInfo.impulse*40);
			hit_obstracle = true;
		}
	}



}
