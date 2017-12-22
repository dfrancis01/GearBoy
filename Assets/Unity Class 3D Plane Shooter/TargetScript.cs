using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("LazerBeam"))
        {
            Destroy(other.gameObject);
        }
        Destroy(this.gameObject);
    }
}
