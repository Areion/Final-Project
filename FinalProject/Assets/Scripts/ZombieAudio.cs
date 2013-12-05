using UnityEngine;
using System.Collections;

public class ZombieAudio : MonoBehaviour {



	void OnTriggerEnter( Collider coll ) {
		if( collider.tag == "Player1" || collider.tag == "Player2" ) {
			if ( coll.GetComponent<PlayerState>().isZombie == false ) {
				coll.GetComponent<PlayerState>().otherPlayer.GetComponent<AudioListener>().enabled = false;
				coll.GetComponent<AudioListener>().enabled = true;
				print ("AudioListener is " + coll.tag );
			}
		}
	}
}
