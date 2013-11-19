using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZombieAI : MonoBehaviour {
	
		GameObject closestPlayer;
		GameObject[] players;
		float closestDistance = 1000000f;
		
		
//	void OnCollisionEnter(Collision collision){
//		
//		if (collision.gameObject == CompareTag("Player")){
//			DestroyObject (GameObject.FindGameObjectsWithTag("Player"));
//		}
//	}

	// Use this for initialization
	void Start () {
		players = GameObject.FindGameObjectsWithTag("Player");
        
	}
	
	// Update is called once per frame
	void Update () {
		
		foreach (GameObject player in players){

		Vector3 distance = player.transform.position - transform.position;

		if (distance.magnitude < closestDistance){
		closestPlayer = player;
		closestDistance = distance.magnitude;
		transform.Translate(0f  * Time.deltaTime, 0f  * Time.deltaTime, 1f  * Time.deltaTime);
			}
			
		transform.LookAt (player.transform.localPosition);
			
		}
	}
}