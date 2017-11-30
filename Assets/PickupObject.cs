using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {
	private bool triggered;
	private AudioSource picUpSfx;

	void Awake(){
		picUpSfx = gameObject.GetComponent<AudioSource> ();
	}
	void Update(){
		if(triggered && !picUpSfx.isPlaying)
			Destroy (this.gameObject);
	}
	public void OnTriggerEnter2D(Collider2D collide){
		Debug.Log ("Destroy the game object");
		GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Score> ().IncreasScore (1);
		//Destroy (this.gameObject);
		//picUpSfx = this.gameObject.GetComponentInChildren(typeof(AudioSource)) as AudioSource;
		//picUpSfx.Play ();
		triggered = true;
		picUpSfx.enabled = true;
		picUpSfx.Play ();
	}
}
