using UnityEngine;
using System.Collections;

public class BulletAction : MonoBehaviour {
	//public int shotType;
	//public int speed;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 0.25f);
	}

	void OnBecameInvisible(){
		//GameObject.Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(){
		//GameObject.Destroy (gameObject);
	}
}
