using UnityEngine;
using System.Collections;

public class LethalCollider : MonoBehaviour {

	void OnCollisionEnter(Collision collision){

		Frog frog = collision.gameObject.GetComponent<Frog> ();
		if (frog != null) {
			LevelManager lm = FindObjectOfType<LevelManager> ();
			lm.IsGameOver = true;
		}

	}
}
