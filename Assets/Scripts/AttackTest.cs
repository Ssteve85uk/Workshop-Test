using UnityEngine;
using System.Collections;

public class AttackTest : MonoBehaviour {
	public GameObject bulletSource;
	public GameObject b;
	public GameObject b2;
	public GameObject b3;
	public float comboTime1, comboTime2;
	public int combo;
	public int pick;
	// Use this for initialization
	void Start () {
		comboTime1 = 0.0f;
		comboTime2 = 0.0f;
		combo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ChangePick ();
		Vector3 bPos = new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z);

		if (Time.time > comboTime1) {
			combo = 0;
			GetComponent<SpriteRenderer>().color = Color.blue;
			if (b != null){
				Destroy(b);
			}
			if (b2 != null){
				Destroy(b2);
			}
			if (b3 != null){
				Destroy(b3);
			}
		}
		if (Input.GetKeyDown (KeyCode.Z) && Time.time > comboTime1 && combo == 0) {
			combo = 1;
			comboTime1 = Time.time + 1.0f;
			GetComponent<SpriteRenderer>().color = Color.magenta;
			b = Instantiate (bulletSource, bPos, Quaternion.identity) as GameObject;
			ChangeAttack (b);
		}
		else if (combo == 1 && Time.time < comboTime1 && Input.GetKeyDown (KeyCode.Z)){
			Destroy (b);
			combo = 2;
			GetComponent<SpriteRenderer>().color = Color.white;
			b2 = Instantiate (bulletSource, bPos, Quaternion.identity) as GameObject;
			ChangeAttack (b2);
			b2.transform.localScale = new Vector3 (b2.transform.localScale.x + 2, b2.transform.localScale.y + 2, b2.transform.localScale.z);
		}
		else if (combo == 2 && Time.time < comboTime1 && Input.GetKeyDown (KeyCode.Z)){
			Destroy (b2);
			combo = 3;
			GetComponent<SpriteRenderer>().color = Color.yellow;
			b3 = Instantiate (bulletSource, bPos, Quaternion.identity) as GameObject;
			ChangeAttack (b3);
			b3.transform.localScale = new Vector3 (b2.transform.localScale.x + 4, b2.transform.localScale.y + 4, b2.transform.localScale.z);
		}
	}

	public void ChangePick () {
		if (Input.GetKeyDown (KeyCode.Alpha1))
			pick = 1;
		if (Input.GetKeyDown (KeyCode.Alpha2))
			pick = 2;
		if (Input.GetKeyDown (KeyCode.Alpha3))
			pick = 3;
		if (Input.GetKeyDown (KeyCode.Alpha4))
			pick = 4;
	}
	public void ChangeAttack(GameObject g){
		if (pick == 1)
			g.GetComponent<SpriteRenderer>().color = Color.red;
		if (pick == 2)
			g.GetComponent<SpriteRenderer>().color = Color.green;
		if (pick == 3)
			g.GetComponent<SpriteRenderer>().color = Color.cyan;
		if (pick == 4)
			g.GetComponent<SpriteRenderer>().color = Color.black;
	}
}
