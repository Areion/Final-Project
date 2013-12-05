using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {


	void Update () {

		// if the player clicks the left mouse button
		if (Input.GetMouseButtonDown (0) ) {
				Application.LoadLevel(1);
		}
	}
}
