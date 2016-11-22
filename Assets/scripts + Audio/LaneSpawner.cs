using UnityEngine;
using System.Collections;

public class LaneSpawner : MonoBehaviour {

	public GameObject[] lanePrefabs;


	// Use this for initialization
	void Start () {
		int offset = -10;
		while (offset < 500)
		{
			createRandomLane(offset);
			offset += 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createRandomLane(float offset)
	{

		int laneIndex = Random.Range (0, lanePrefabs.Length);
		var lane = Instantiate (lanePrefabs[laneIndex]);
		lane.transform.parent = transform;
		lane.transform.Translate (0, 0, offset);
	}
		
}
