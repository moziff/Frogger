using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaterTrunkSpawner : MonoBehaviour {
	public Vehicle prefab;
	public List<Vehicle> vehicle_list;


	public float meanTime = 5.0f;
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
		vehicle = Instantiate<Vehicle>(prefab);
		vehicle.transform.parent = transform;
		vehicle.transform.localPosition = new Vector3(.5f, .17f, 0);
		vehicle.setSpeed = 0.3f;
		vehicle_list.Add (vehicle);
		//		
	}
}
