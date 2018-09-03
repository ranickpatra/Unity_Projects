using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad_moving : MonoBehaviour {

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float input = Input.GetAxis ("Horizontal");
		if(input > 0)
			rb.velocity = new Vector2 (10, 0);
		else if(input < 0)
			rb.velocity = new Vector2 (-10, 0);
		else
			rb.velocity = new Vector2 (0, 0);

	}
}
