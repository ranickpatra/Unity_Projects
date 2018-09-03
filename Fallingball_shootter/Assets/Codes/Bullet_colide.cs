using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_colide : MonoBehaviour {


	public GameObject explosion;

	

	void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag != "Player")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
	} 

}
