using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeraldMover : MonoBehaviour
{
	public float jumpAmount = 5.0f;
	public float speed;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jumpValue = 0.0f;
		if (Input.GetKey (KeyCode.Space)) {
			if (transform.position.y < 1) {
				jumpValue = jumpAmount;
			}
		}

		Vector3 movment = new Vector3 (moveHorizontal, jumpValue, moveVertical);
		rb.AddForce (movment * speed);
	}

}