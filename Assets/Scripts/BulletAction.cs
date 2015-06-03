using UnityEngine;
using System.Collections;

public class BulletAction : MonoBehaviour {
	public float speed;
	public float maxDist;
	public float startX, startY, startZ;
	public GameObject p;
	// Use this for initialization
	void Start () {
		maxDist = 1f;
		startX = transform.position.x;
		startY = transform.position.y;
		startZ = transform.position.z;
		p = GameObject.Find ("Player");
	}
	

	// Update is called once per frame
	void Update () {
		//ChangeSprite();
		if (transform.position.x < (startX + maxDist)) {
			transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), startY, startZ);
		}
		if (transform.position.x < p.transform.position.x + 1.5f) {
			transform.position = new Vector3 (p.transform.position.x + 1.5f, transform.position.y, transform.position.z);
		}
	}

	/*public void ChangeSprite(){
		if (p.GetComponent<AttackTest> ().pick == 1) {
			GetComponent<SpriteRenderer>().color = Color.red;
		}
		if (p.GetComponent<AttackTest> ().pick == 2) {
			GetComponent<SpriteRenderer>().color = Color.green;
		}
		if (p.GetComponent<AttackTest> ().pick == 3) {
			GetComponent<SpriteRenderer>().color = Color.cyan;
		}
		if (p.GetComponent<AttackTest> ().pick == 4) {
			GetComponent<SpriteRenderer>().color = Color.black;
		}
	}*/
	void OnCollisionEnter(){
		//GameObject.Destroy (gameObject);
	}
}
