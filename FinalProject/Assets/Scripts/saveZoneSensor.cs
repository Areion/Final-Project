using UnityEngine;
using System.Collections;
public class saveZoneSensor : MonoBehaviour {
	public bool player1isSafe = false;
	public bool player2isSafe = false;


	void Update () {
		if ( player1isSafe && player2isSafe ) {
			Application.LoadLevel(3);
			//the code here will be called when both players are in the safe zone
			//so put the code that brings up the Win Screen here!!  
		}
	}
	
	
	void OnTriggerStay(Collider collider) {
		print ("hit trigger");
		 if(  collider.tag == "Player1" ) player1isSafe = true;
		 if(  collider.tag == "Player2" ) player2isSafe = true;
	}
	
	void OnTriggerExit(Collider collider) {
		if(  collider.tag == "Player1" ) player1isSafe = false;
		if(  collider.tag == "Player2" ) player2isSafe = false;	
	}
}
