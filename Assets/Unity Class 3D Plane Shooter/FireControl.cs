using UnityEngine;
using System.Collections;

public class FireControl : MonoBehaviour {
    [SerializeField]
    private GameObject lazerMuzzel;
    [SerializeField]
    private GameObject lazerBeam;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(lazerBeam,lazerMuzzel.transform.position,lazerMuzzel.transform.rotation);
        }
        ;
	}
}
