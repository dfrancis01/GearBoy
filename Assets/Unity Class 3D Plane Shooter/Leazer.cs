using UnityEngine;
using System.Collections;

public class Leazer : MonoBehaviour {
    [SerializeField]
    private float speed = 300.0f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += this.transform.up * speed * Time.deltaTime;
	}
}
