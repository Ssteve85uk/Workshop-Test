using UnityEngine;
using System.Collections;

public class AttackTest : MonoBehaviour {
	/*public GameObject bulletSource;
	public GameObject b;
	public GameObject b2;
	public GameObject b3;*/
	public float comboTime1, comboTime2;
	public int combo;
	public GameObject fire;
	// Use this for initialization
	void Start () {
		comboTime1 = 0.0f;
		comboTime2 = 0.0f;
		combo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 bPos = new Vector3 (transform.position.x + 1.5f, transform.position.y +0.5f, transform.position.z);
		if (Time.time > comboTime1) {
			combo = 0;
			GetComponent<SpriteRenderer>().color = Color.blue;
		}
		if (Input.GetKeyDown (KeyCode.Z) && Time.time > comboTime1 && combo == 0) {
			combo = 1;
			comboTime1 = Time.time + 0.25f;
			GetComponent<SpriteRenderer>().color = Color.red;
			fire.SetActive(true);
			//b = Instantiate (bulletSource, bPos, Quaternion.identity) as GameObject;
		}
		else if (combo == 1 && Time.time < comboTime1 && Input.GetKeyDown (KeyCode.Z)){
			comboTime1 += 0.5f;
			combo = 2;
			GetComponent<SpriteRenderer>().color = Color.green;
			//b2 = Instantiate (bulletSource, bPos, Quaternion.identity) as GameObject;
			//b2.transform.localScale = new Vector3 (b2.transform.localScale.x + 3, b2.transform.localScale.y + 3, b2.transform.localScale.z);
		}
		else if (combo == 2 && Time.time < comboTime1 && Input.GetKeyDown (KeyCode.Z)){
			comboTime1 += 0.5f;
			combo = 3;
			GetComponent<SpriteRenderer>().color = Color.yellow;
			//b3 = Instantiate (bulletSource, bPos, Quaternion.identity) as GameObject;
			//b3.transform.localScale = new Vector3 (b2.transform.localScale.x + 6, b2.transform.localScale.y + 6, b2.transform.localScale.z);
		}
	}
	
}
