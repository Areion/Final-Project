using UnityEngine;
using System.Collections;

public class antidoteBehavior : MonoBehaviour {
	
	public bool beingCarried = false;
	
	
	void OnTriggerEnter( Collider coll ) {
		if ( coll.tag == "Player1" || coll.tag == "Player2" ) {
			
			//CURING SOMEONE WITH ANTIDOTE
			if ( beingCarried  && ( coll.GetComponent<PlayerState>().isZombie == true ) ) {
				coll.GetComponent<PlayerState>().isZombie = false;
			}

			//PICKING UP ANTIDOTE
			else if ( coll.GetComponent<PlayerState>().isZombie == false ) {

				////TEST
				audio.Play (); //params are delay
				////TEST

				transform.parent = coll.GetComponent<Transform>();
				beingCarried = true;
			}
			
			
		}
		
	}
}