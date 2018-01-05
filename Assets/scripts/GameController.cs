using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject obstacle;

	void Start () {
		InvokeRepeating("createObstacle", 0F, 1.0F);

	}
	
	void Update () {
		
	}

	void createObstacle(){
		Instantiate(obstacle, new Vector3(5, Random.Range(-1.8F, 4.5F), -0.1F), Quaternion.Euler(new Vector3(0, 0, 90)));
	}
}
