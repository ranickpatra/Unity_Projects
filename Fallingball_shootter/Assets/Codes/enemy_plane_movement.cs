using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_plane_movement : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {

        player = GameObject.Find("Player");
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(player.transform.position.y - transform.position.y,
            player.transform.position.x - transform.position.x) * Mathf.Rad2Deg - 90, Vector3.forward);
        //gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * 5;

    }
}
