﻿using UnityEngine;
using System.Collections;

public class LookY : MonoBehaviour {

	public float posY;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate() {
	  posY = Input.GetAxis("Mouse Y");
	  Vector3 rot = transform.localEulerAngles;
	  rot.x += posY * speed;
	  transform.localEulerAngles = rot;
	}
}
