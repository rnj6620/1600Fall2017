using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour {

	public CharacterController characterController;
	public static bool gameOver;
	public float gravity = 9.81f; // creates a gravity component, defaults to 9.81
	public float speed = 10;
	public float jumpForce = 50; // creates jump 
	public Vector3 moveVector3; // temp variable that will store temp data

	void Update () {
		moveVector3.y -= gravity * Time.deltaTime; // will slow this down and make it coorelate with time

		if(characterController.isGrounded && !gameOver){ // looks to see if character is on ground first
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // if so, can move

			if(Input.GetKeyDown(KeyCode.Space)){ // if its on ground, can jump
				moveVector3.y = jumpForce * Time.deltaTime; // creates jumpforce (shoots up)
			}
		}
	
		characterController.Move(move);

	}
}
