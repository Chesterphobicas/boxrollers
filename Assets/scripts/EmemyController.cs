using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmemyController : MonoBehaviour
{
	private	Transform player;
	public int moveSpeed = 3;
	public int rotationSpeed = 3;

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update ()
	{
		//rotate to look at the player
		transform.rotation = Quaternion.Slerp (transform.rotation,
			Quaternion.LookRotation (player.position - transform.position), rotationSpeed * Time.deltaTime);
		float currentMoveSpeed = Random.Range (-0.01f, moveSpeed);
		//move towards the player
		transform.position += transform.forward * currentMoveSpeed * Time.deltaTime;


		float x = Random.Range(-0.01f, 0.01f) + transform.position.x;
		float y = 0.5f;
		float z = Random.Range (-0.01f, 0.01f) + transform.position.z;
		transform.position = new Vector3(x, y, z);
	}
}
