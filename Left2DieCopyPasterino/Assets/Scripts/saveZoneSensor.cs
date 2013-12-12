using UnityEngine;
using System.Collections;
public class saveZoneSensor : MonoBehaviour {

	public bool player1isSafe = false;
	public bool player2isSafe = false;
	
	void Update () {
		if ( player1isSafe && player2isSafe ) {
			Application.LoadLevel (3);
			
		}
	}
	
	void OnTriggerStay( Collider collider ) {

		if ( collider.tag == "Player1" || collider.tag == "Player2" ) {
			if ( collider.GetComponent<PlayerState>().isZombie == false ) {
				if(  collider.tag == "Player1" ) player1isSafe = true;
				else if(  collider.tag == "Player2" ) player2isSafe = true;
			}
		}
	}
	
	void OnTriggerExit(Collider collider) {
		if(  collider.tag == "Player1" ) player1isSafe = false;
		if(  collider.tag == "Player2" ) player2isSafe = false;	
	}
}
