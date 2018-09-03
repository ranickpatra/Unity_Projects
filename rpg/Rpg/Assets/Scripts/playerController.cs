using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(playerMotor))]
public class playerController : MonoBehaviour {

    public LayerMask movementMask;
    playerMotor motor;

    Camera cam;

	// Use this for initialization
	void Start () {
        this.cam = Camera.main;
        this.motor = GetComponent<playerMotor>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // move out player to what we hit
                motor.moveToPoint(hit.point);
                

                // stop focusing any objects

            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // check if we hit an interractable
                // if we hit set if as out focus

            }
        }

    }
}
