using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D collide){
		Debug.Log ("Destroy the game object");
		GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Score> ().IncreasScore (1);
		Destroy (this.gameObject);
		
	}
}
