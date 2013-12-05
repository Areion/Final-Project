using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public Transform cam;
	public float camSpeed;

	void Update () {
		GameObject player1 = GameObject.FindWithTag("Player1");
		GameObject player2 = GameObject.FindWithTag("Player2");
		Vector3 player1Movement = player1.transform.forward * player1.GetComponent<PlayerMovement>().moveVector.z;
		Vector3 player2Movement = player2.transform.forward * player2.GetComponent<PlayerMovement>().moveVector.z;
		cam.position += camSpeed * ( player1Movement + player2Movement );
	}
}
