using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

	public float setSpeed { get; set;}

	Vector3 transform_delta;
	Vector3 origin; 


	// Use this for initialization
	void Start () {
		origin = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		carMovement ();

	}

	void carMovement() {
		transform.position += Vector3.left * setSpeed;
//		transform_delta = origin - transform.position;
	}
}
