using UnityEngine;
using System.Collections;

public class Deathbox : MonoBehaviour {

	public GameObject player;
	public GameObject spawn;

	public void OnTriggerEnter2D (Collider2D collide){
		player.transform.position = spawn.transform.position;
	}
}
