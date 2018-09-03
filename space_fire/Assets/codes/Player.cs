using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    private Vector2 movingVector;

	//public GameObject prefabs;
	//public Quaternion rotates;

	// Use this for initialization
	void Start () {

        movingVector = new Vector2(4, 0);
		//rotates = new Quaternion (0, 0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey("a")) {
            rb.position -= movingVector*Time.deltaTime;
        } else if(Input.GetKey("d")){
            rb.position += movingVector*Time.deltaTime;
        }


		if (Input.GetMouseButtonDown (0)) {
			//GameObject obj = Instantiate (prefabs, transform.position + new Vector3 (1, 0, 0), rotates);
			//obj.AddComponent <Rigidbody2D>();
		}

	}
}
