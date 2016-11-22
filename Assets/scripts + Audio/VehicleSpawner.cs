using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {
	public Vehicle[] vehicle_prefabs;

	public float lane_speed = 1.0f;

	private Vehicle vehicle;


	// Use this for initialization
	void Start () {
		int vehicleIndex = Random.Range (0, vehicle_prefabs.Length);
		vehicle = Instantiate<Vehicle>(vehicle_prefabs[vehicleIndex]);
		vehicle.transform.parent = transform;
		vehicle.transform.localPosition = new Vector3(.5f, .5f, 0);
		vehicle.setSpeed = lane_speed;
	}
	
	// Update is called once per frame
	void Update () {
//		vehicle.carMovement ();
	}

}
