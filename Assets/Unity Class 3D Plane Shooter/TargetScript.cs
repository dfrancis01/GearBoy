using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {
    [SerializeField]
    private GameObject particalEffect;
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
        GameObject.Instantiate(particalEffect, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
        
    }
}
