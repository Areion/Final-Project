using UnityEngine;
using System.Collections;

public class Instructions2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//if 
		
		// if the player clicks the left mouse button
		if (Input.GetMouseButtonDown (0) ) {
				Application.LoadLevel(2);
		}
	}
}
