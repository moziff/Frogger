using UnityEngine;
using System.Collections;

public class Vehicle : MonoBehaviour {

	public float setSpeed { get; set;}


	public int length = -10;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		carMovement ();
	}

	void carMovement() {
		transform.position += Vector3.left * setSpeed;
		if (transform.position.x < length) {
			Destroy (gameObject);
		}
	}
}
