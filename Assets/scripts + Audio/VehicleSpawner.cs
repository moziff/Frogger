using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {
	public Vehicle[] vehicle_prefabs;

	public float lane_speed;

	private Vehicle vehicle;

	public float length = -.52f;

	// Use this for initialization
	void Start () {
		CreateVehicle ();
	}
	
	// Update is called once per frame
	void Update () {
		if (vehicle.transform.localPosition.x < -0.5f) {
			Destroy(vehicle.gameObject);
			CreateVehicle ();
		}
	}

	void CreateVehicle(){
		int vehicleIndex = Random.Range (0, vehicle_prefabs.Length);
		vehicle = Instantiate<Vehicle>(vehicle_prefabs[vehicleIndex]);
		vehicle.transform.parent = transform;
		vehicle.transform.localPosition = new Vector3(.5f, .5f, 0);
		vehicle.setSpeed = Random.Range(0.7f,2.0f);
//		
	}

}
