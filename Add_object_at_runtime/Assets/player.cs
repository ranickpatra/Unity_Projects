using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public GameObject objecttoSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject obj = Instantiate (objecttoSpawn, transform.position + new Vector3 (10, 20, 40), transform.rotation);
		}

	}
}
