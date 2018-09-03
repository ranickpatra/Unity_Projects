using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public Rigidbody2D ball_rigidBody;

	// Use this for initialization
	void Start () {
		//Vector2 speed = new Vector2 (1, -4);
		//ball_rigidBody.velocity = speed;
		//vel_zero = speed;
	}
	
	// Update is called once per frame
	void Update () {
		if(ball_rigidBody.velocity.y == 0f)
			ball_rigidBody.velocity += new Vector2(0, 4);
		if(ball_rigidBody.velocity.x == 0f)
			ball_rigidBody.velocity += new Vector2(4, 0);
	}
}
