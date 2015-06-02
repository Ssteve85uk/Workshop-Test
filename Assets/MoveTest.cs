using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {
	public float speed;
	public float jPower;
	public CharacterController controller;
	Vector3 movement = Vector3.zero;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.x = Input.GetAxis ("Horizontal") * speed;
		movement.z = Input.GetAxis ("Vertical") * speed;

		if (controller.isGrounded == false)
			movement.y += Physics.gravity.y * Time.deltaTime;

		if (Input.GetButton ("Jump") && controller.isGrounded == true)
			movement.y = jPower;

		controller.Move (movement * Time.deltaTime);
	}
}
