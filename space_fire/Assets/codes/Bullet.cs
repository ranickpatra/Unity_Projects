using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour {

	public GameObject prefabs;
	private Quaternion rotates;

	public Bullet() {
		rotates = new Quaternion (0, 0, 0, 0);
	}

	public void add_Bullet() {
		GameObject obj = Instantiate (prefabs, transform.position + new Vector3 (0, 0, 0), rotates);
		Rigidbody2D rb = obj.GetComponent <Rigidbody2D> ();
		rb.AddForce (new Vector2(0, 100));

	}


	void Update() {
		if(Input.GetMouseButtonDown (0))
			add_Bullet ();
	}



}


