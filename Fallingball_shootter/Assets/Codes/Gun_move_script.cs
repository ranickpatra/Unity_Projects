using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_move_script : MonoBehaviour {

	public Rigidbody2D gun;
	Vector2 gun_speed_x, gun_speed_y, velocity;
	Vector2 zero_speed, touch_position;
	double touch_offset = 0.08;
	float theta;
	Quaternion rotation;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
		gun_speed_x = new Vector2 (100, 0);
		gun_speed_y = new Vector2 (0, 100);
		velocity = new Vector2 (0, 0);
		zero_speed = new Vector2 (0, 0);
		touch_position = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.touchCount == 0) {
			gun.velocity = zero_speed;
		} else if (Input.touchCount == 1) {
			
			touch_position = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);

			velocity.x = touch_position.x - transform.position.x;
			velocity.y = touch_position.y - transform.position.y;
			theta = Mathf.Atan2 (velocity.y, velocity.x);
			velocity.x = Mathf.Abs (velocity.x);
			velocity.y = Mathf.Abs (velocity.y);

			if ((velocity.x - touch_offset > 0) && (velocity.y - touch_offset > 0)) {
				//transform.rotation = Quaternion.Euler (transform.rotation.eulerAngles + new Vector3 (0, 0, theta * 180 / Mathf.PI - 90) * Time.deltaTime);
				transform.rotation = Quaternion.AngleAxis (theta*Mathf.Rad2Deg-90, Vector3.forward);
			}

			if (velocity.x - touch_offset > 0)
				velocity.x = 2 * Mathf.Cos (theta);
			else
				velocity.x = 0;
			if (velocity.y - touch_offset > 0)
				velocity.y = 2 * Mathf.Sin (theta);
			else
				velocity.y = 0;


			gun.velocity = velocity;

		}
		
	}


    // handle the colliton
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.tag != "messile_player" && col.tag != "enemy")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }


}
