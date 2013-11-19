using UnityEngine;
using System.Collections;

public class ZombieAI : MonoBehaviour {
	
		public Transform Player1; //Drag Player1's object in the Hierarchy onto this in the inspector
		public Transform Player2; //Drag Player2's object in the Hierarchy onto this in the inspector
	
//	void OnCollisionEnter(Collision collision){
//		
//		if (collision.gameObject == CompareTag("Player")){
//			DestroyObject (GameObject.FindGameObjectsWithTag("Player"));
//		}
//	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 distance1 = (Player1.position - transform.position);
		Vector3 distance2 = (Player2.position - transform.position);
		
		
		// change the z translate to a public variable
		if (distance1.magnitude < distance2.magnitude) {
			transform.LookAt (Player1);
			transform.Translate (0f * Time.deltaTime, 0f * Time.deltaTime, 5f * Time.deltaTime);
			
		}else{
			transform.LookAt (Player2);
			transform.Translate (0f * Time.deltaTime, 0f * Time.deltaTime, 5f * Time.deltaTime);
			
		}
	}
}