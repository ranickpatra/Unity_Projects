using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_2_explode : MonoBehaviour {

    public GameObject explosion;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.tag != "messile_player") {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
       // }
    }
}
