using UnityEngine;
using System.Collections;

public class FireWall : MonoBehaviour {

	public float creep_velocty=0.05f;

	private Frog player;
	private LevelManager lm;

	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Frog>();
		lm = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		HorizontalFollow ();
		ForwardCreep ();
		IsBurnt ();
	}

	void HorizontalFollow () {
		Vector3 delta = player.transform.position - transform.position;
		Vector3 projectedDelta = Vector3.Project(delta, Vector3.left);
		transform.position += projectedDelta;
	}

	void ForwardCreep(){
		transform.position += Vector3.forward * creep_velocty;
	}

	void IsBurnt(){

		if (player.transform.position.z < transform.position.z) {
			lm.IsGameOver = true;
		}
		
	}
}
