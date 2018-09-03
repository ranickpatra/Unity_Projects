using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
	public Rigidbody2D plane_body;
	public GameObject prefabs;
	private Quaternion rotates;
	private Vector3 fireOffset;
	private int bullet_speed;
	private int max_messile = 20;
	private Bullet_Single[] game_obj_arr;
	public Camera cam;
	double last_fired_time = 0.0;
    public string fromObj;

	void Start ()
	{
		rotates = new Quaternion (0, 0, 0, 0);
		fireOffset = new Vector3 (0, 0.4f, 0);
		bullet_speed = 250;
		game_obj_arr = new Bullet_Single[max_messile];
		for (int i = 0; i < max_messile; i++) {		// initialize the array
			game_obj_arr [i] = new Bullet_Single (null, Time.realtimeSinceStartup);
		}
	}

	public Bullet_Single fire ()
	{
		float theta = transform.localRotation.z;
		//GameObject obj = Instantiate (prefabs, transform.position + fireOffset, rotates);
		GameObject obj = Instantiate (prefabs, transform.position, rotates);
		//GameObject obj = Instantiate (prefabs, transform.position + Quaternion.Euler (0, 45, 0) * fireOffset, rotates);
		//obj.transform.Rotate (new Vector3(0, 0, theta*180/Mathf.PI));
		//obj.transform.Rotate (transform.rotation.ToEulerAngles () * 180 / Mathf.PI);
		Vector3 rtion = GameObject.Find (fromObj).transform.rotation.eulerAngles;
		obj.transform.Rotate(rtion);
		obj.GetComponent <Rigidbody2D> ()
			.AddForce (new Vector3(bullet_speed*Mathf.Sin (-rtion.z*Mathf.PI/180), bullet_speed*Mathf.Cos (rtion.z*Mathf.PI/180), 0));		// add stating speed to bullet
		return new Bullet_Single (obj, Time.realtimeSinceStartup + 5);
	}

	void Update ()
	{
		if (Input.touchCount >= 2) {		// if player double touch
			float current_time = Time.realtimeSinceStartup;
			for (int i = 0; i < max_messile; i++) {
				if (game_obj_arr [i].time < current_time) {
					// destoy game object if it is not null
					if (game_obj_arr [i].gameObject != null) {
						Destroy (game_obj_arr [i].gameObject);
					}

					if (last_fired_time < current_time) {
						game_obj_arr [i] = fire ();
						last_fired_time = current_time + 0.2;
					}

				}
			}

		}


	}


}
