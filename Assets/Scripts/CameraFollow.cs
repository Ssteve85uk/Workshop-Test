using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	GameObject p;
	// Use this for initialization
	void Start () {
		p = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (p.transform.position.x, transform.position.y, transform.position.z);
	}
}
