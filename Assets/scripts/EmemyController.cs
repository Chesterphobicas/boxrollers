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

		//move towards the player
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
	}
}
