using UnityEngine;
using System.Collections;

public class GameOverMessage : MonoBehaviour {

	public float UIDistance = 150.0f;
	public float UIHeight = 1.0f;

	private Frog player;
	private LevelManager lm;

	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Frog>();
		lm = GameObject.FindObjectOfType<LevelManager>();
		GetComponent<Canvas> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (lm.IsGameOver) {
			
			transform.rotation = Quaternion.LookRotation(player.LookDirection());
			transform.position = player.transform.position;
			transform.position += player.LookDirection() * UIDistance;
			transform.position += Vector3.up * UIHeight;
			GetComponent<Canvas> ().enabled = true;
		}


	}
}
