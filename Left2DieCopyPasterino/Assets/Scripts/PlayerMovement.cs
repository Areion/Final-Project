using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public Vector3 moveVector;
	float speed = 0.7f;
	float turnSpeed = 500f;
	
	void Update () {
		moveVector = Vector3.zero;

		//ZOMBIE MOVEMENT
		if ( GetComponent<PlayerState>().isZombie == true ) {
			GetComponent<NavMeshAgent>().enabled = true;
			collider.isTrigger = true;
			GameObject otherPlayer = GetComponent<PlayerState>().otherPlayer;
			if ( GetComponent<NavMeshAgent>().enabled ) GetComponent<NavMeshAgent>().SetDestination( otherPlayer.transform.position );
		}

		//HUMAN MOVEMENT
		else {
			GetComponent<NavMeshAgent>().enabled = false;
			collider.isTrigger = false;
			if ( rigidbody.velocity.magnitude > 0.01f ) GetComponentInChildren<Animation>().CrossFade ("Walk");
			else GetComponentInChildren<Animation>().CrossFade ("Idle");

			if ( tag == "Player1" ) movePlayer1();
			else if ( tag == "Player2" ) movePlayer2();
		}
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

	void OnTriggerEnter( Collider coll ) {
		if ( coll.tag == "Player1" || coll.tag == "Player2" ) {
			coll.GetComponent<PlayerState>().isZombie = true;
		}

	}
}