using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public Transform cam;
	public float camSpeed;
	public Player1Script playerOne;
	public Player2Script playerTwo;
	
	void Start () {
	//Transform cam = Camera.main.transform;
	}

	void Update () {
	// add the movement vectors of player 1 and player 2 and assign it to cam. 

 	cam.position += camSpeed *( (playerOne.transform.forward * playerOne.moveVector.z) + (playerTwo.transform.forward * playerTwo.moveVector.z));
	

	}
}
