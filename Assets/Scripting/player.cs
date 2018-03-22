using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour 
{
	public float horizontalMovementSpeed = 10f;
	public float vericalJumpInitialSpeed = 250f;

	public Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movementHorizontal = new Vector3 (moveHorizontal, 0.0f, 0);
		rb.AddForce (movementHorizontal * horizontalMovementSpeed);
	}

	void OnCollisionEnters2D (Collider other) 
	{
		if (other.gameObject.tag == "Ground") 
		{
			if (Input.GetKeyDown (KeyCode.Z)) 
			{
				rb.AddForce(Vector3.up * vericalJumpInitialSpeed);
			}
		}
	}
}