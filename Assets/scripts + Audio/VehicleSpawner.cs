using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VehicleSpawner : MonoBehaviour {
	public Vehicle[] vehicle_prefabs;
	public List<Vehicle> vehicle_list;


	public float meanTime = 2;

	float nextSpawnTime = 0;

	public float lane_speed;

	private Vehicle vehicle;

	public float length = -.52f;

	// Use this for initialization
	void Start () {
		CreateVehicle ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime)
		{
			CreateVehicle();
			nextSpawnTime = Time.time - Mathf.Log (Random.value) * meanTime;
		}
		foreach (Vehicle veh in vehicle_list) {
			if (veh.transform.localPosition.x < -0.5f) {
				vehicle_list.Remove (veh);
				Destroy(veh.gameObject);
			}
		}

	}

	void CreateVehicle(){
		int vehicleIndex = Random.Range (0, vehicle_prefabs.Length);
		vehicle = Instantiate<Vehicle>(vehicle_prefabs[vehicleIndex]);
		vehicle.transform.parent = transform;
		vehicle.transform.localPosition = new Vector3(.5f, .5f, 0);
		vehicle.setSpeed = 0.6f;
		vehicle_list.Add (vehicle);
	}
}
