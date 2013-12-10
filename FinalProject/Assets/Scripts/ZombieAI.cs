using UnityEngine;
using System.Collections;

public class ZombieAI : MonoBehaviour {
	
	public Transform Player1;
	public Transform Player2;
	public float minDistance = 100f;
	public float randomDestinationSwitch = 5f; //set a different random location as destination every 5 seconds
	bool tooFar = true;
	
	Animation myAnimation;

	void Start () {
		InvokeRepeating( "RandomRoam", 0f, randomDestinationSwitch );
		
		myAnimation = GetComponentInChildren<Animation>();
	}


	void RandomRoam() {
		if ( tooFar ) {
			GetComponent<NavMeshAgent>().SetDestination( Random.insideUnitSphere * 15 );
		}
	}

		
	void Update () {
	
		myAnimation.CrossFade ("Walk");
				
		Vector3 distance1 = (Player1.position - transform.position);
		Vector3 distance2 = (Player2.position - transform.position);

		if ( distance1.magnitude > minDistance ) tooFar = true;

		//CLOSE ENOUGH TO FOLLOW
		else {
			tooFar = false;
			if ( distance1.magnitude < distance2.magnitude 
			    && Player1.GetComponent<PlayerState>().isZombie == false
			    && distance1.magnitude < minDistance )
				GetComponent<NavMeshAgent>().SetDestination( Player1.transform.position );	

			else if ( Player2.GetComponent<PlayerState>().isZombie == false 
			         && distance1.magnitude < minDistance ) 
				GetComponent<NavMeshAgent>().SetDestination( Player2.transform.position );	
		}
	}

	void OnTriggerEnter(Collider collider){
		if ( collider.tag == "Player1" || collider.tag == "Player2" ) {
			collider.GetComponent<PlayerState>().isZombie = true;
		}
	}

}