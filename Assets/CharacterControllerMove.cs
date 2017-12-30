﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerMove : MonoBehaviour {

	public float jumpSpeed = 8.0F;
	public Rigidbody rb;
	public float fallSpeed = -5;
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		rb.velocity = new Vector3(0,-5, 0);
		if (Input.GetKey(KeyCode.Space))
		{
			transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
		}
	}
}