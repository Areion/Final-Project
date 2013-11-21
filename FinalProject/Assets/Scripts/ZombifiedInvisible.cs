using UnityEngine;
using System.Collections;

public class ZombifiedInvisible : MonoBehaviour {
	
	public bool isZombie = false;
	

	void Start () { }
	

	void Update () {
		
		if ( isZombie == true ) {
			transform.parent.renderer.enabled = false;
		}
	}
	
	void OnTriggerEnter (Collider TestColl) {
		// make sure to TAG the ZOMBIES
		if ( TestColl.tag == "Zombie" ) {
			isZombie = true;	
		}
	}
}
