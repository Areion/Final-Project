using UnityEngine;
using System.Collections;

public class Player1Script : MonoBehaviour {
// first, for camera: parent the camera behind the player, in-editor
	
	public Vector3 moveVector;
	
	public float speed = 15f;
	public float turnSpeed = 90f;
	public float jumpSpeed = 5f;
	public float fallSpeed = 10f;
	//bool grounded = false;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// movement: move forward, back, left, right
		// if the player isn't pushing anything, none of the inputs will fire. reset it to zero every time.
		moveVector = Vector3.zero;
		

		
		if ( Input.GetKey ( KeyCode.W ) ) { // MOVE FORWARD
			moveVector.z = 1f;
		} 
		//if ( Input.GetKeyUp (KeyCode.W ) ) {
		//	moveVector.z = -.3f;
		//} 
		if ( Input.GetKey (KeyCode.S ) ) { // MOVE BACKWARD
			moveVector.z = -1f;
		} 
		//if ( Input.GetKeyUp (KeyCode.S) ) { 
		//	moveVector.z = .3f;
		//}
		
	
		//turning: left and right
		if (Input.GetKey (KeyCode.A) ) {
			transform.Rotate ( 0f, -turnSpeed * Time.deltaTime, 0f );
		} 
		if (Input.GetKey (KeyCode.D) ) {
			transform.Rotate ( 0f, turnSpeed * Time.deltaTime, 0f );
		}
		

		// movement: jumping? how to jump?
		//if ( Physics.Raycast ( transform.position, -transform.up, 1.3f ) ) {
		//	grounded = true;
		//	if ( Input.GetKey ( KeyCode.Space ) ) {
				// just this works as well underneath this if statement:
				//moveVector += new Vector3 ( 0f, jumpSpeed, 0f );
		//		audio.Play();
		//		moveVector += Vector3.up * jumpSpeed;
				
		//	}
		//} else {
		//	grounded = false;
		//}
			
		}
			
	void FixedUpdate() {
	
		//without this line, moveVector doesn't do anything
		rigidbody.AddRelativeForce ( moveVector * speed, ForceMode.VelocityChange );
		
		
		//if (Rigidbody.velocity.magnitude < 10 ) {
			
		//}
	}
}