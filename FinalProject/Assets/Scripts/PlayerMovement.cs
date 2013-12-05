using UnityEngine;
using System.Collections;

// first, for camera: parent the camera behind the player, in-editor

public class PlayerMovement : MonoBehaviour {
	
	public Vector3 moveVector;
	public float speed = 0.7f;
	public float turnSpeed = 800f;

	void Update () {

		moveVector = Vector3.zero; // if user isn't pressing any keys reset movement to zero

		//IF ZOMBIE
		if ( GetComponent<PlayerState>().isZombie == true ) {
			movePlayerLikeZombie();
		}

		//IF NOT A ZOMBIE
		else {
			if ( tag == "Player1" ) movePlayer1();
			else if ( tag == "Player2" ) movePlayer2();
		}
	}

	void movePlayerLikeZombie() {
		GameObject otherPlayer = GetComponent<PlayerState>().otherPlayer;
		transform.LookAt ( otherPlayer.transform );
		transform.Translate ( 0f * Time.deltaTime, 0f * Time.deltaTime, 5f * Time.deltaTime );
	}

	void movePlayer1() {
		if ( Input.GetKey ( KeyCode.W ) ) moveVector.z = 1f; // MOVE FORWARD
		if ( Input.GetKey (KeyCode.S ) ) moveVector.z = -1f; // MOVE BACKWARD
		if (Input.GetKey (KeyCode.A) ) transform.Rotate ( 0f, -turnSpeed * Time.deltaTime, 0f ); // TURN LEFT
		if (Input.GetKey (KeyCode.D) ) transform.Rotate ( 0f, turnSpeed * Time.deltaTime, 0f ); // TURN RIGHT
		rigidbody.AddRelativeForce ( moveVector * speed, ForceMode.VelocityChange ); // ADD FORCE
	}

	void movePlayer2() {
		if ( Input.GetKey ( KeyCode.UpArrow ) ) moveVector.z = 1f; // MOVE FORWARD
		if ( Input.GetKey (KeyCode.DownArrow ) ) moveVector.z = -1f; // MOVE BACKWARD
		if (Input.GetKey (KeyCode.LeftArrow) ) transform.Rotate ( 0f, -turnSpeed * Time.deltaTime, 0f ); // TURN LEFT
		if (Input.GetKey (KeyCode.RightArrow) ) transform.Rotate ( 0f, turnSpeed * Time.deltaTime, 0f ); //TURN RIGHT
		rigidbody.AddRelativeForce ( moveVector * speed, ForceMode.VelocityChange ); // ADD FORCE
	}
}