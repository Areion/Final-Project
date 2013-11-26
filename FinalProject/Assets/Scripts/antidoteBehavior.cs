using UnityEngine;
using System.Collections;

public class antidoteBehavior : MonoBehaviour {
	
	

	void Start () {
		print ( "started script");
	}
	void Update () {}
	
	



	void onTriggerEnter( Collider coll ) {
			print ("collided with Player1");
			//transform.parent = coll.GetComponent<Transform>();	
	}
		

}
