using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterControllerMove : MonoBehaviour {

	public float tapForce = 10;

	public float tiltSmooth = 5;

	public Vector2 startPos;

	Rigidbody2D rigidbody;

	Quaternion downRotation;

	Quaternion forwardRotation;

	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		downRotation = Quaternion.Euler (0, 0, -90);
		forwardRotation = Quaternion.Euler (0, 0, 35);
	}

	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			rigidbody.velocity = new Vector3(0,0, 0);
			transform.rotation = forwardRotation;
			rigidbody.AddForce (Vector2.up * tapForce);

		}
		transform.rotation = Quaternion.Lerp (transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
	}

}
