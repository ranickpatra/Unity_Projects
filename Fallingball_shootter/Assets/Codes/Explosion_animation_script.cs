﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_animation_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
	}



}
