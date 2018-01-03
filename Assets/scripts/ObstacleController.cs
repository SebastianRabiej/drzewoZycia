using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {


	void Start () {
	}
	
	void Update () {
		transform.Translate (Vector3.up * 5 * Time.deltaTime);

	}

}
