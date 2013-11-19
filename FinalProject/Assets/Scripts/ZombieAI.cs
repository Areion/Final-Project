using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZombieAI : MonoBehaviour {
	
		GameObject closestPlayer;
		GameObject[] players;
		float closestDistance = 1000000f;
		
		//public Zombie zombieBlueprint;
		//public int ZombieCount = 15;
		//int randomNumber = 0;
		
		//public List<zombie> zombieList = new List<zombie>(); // you must initialize lists to use them
	
//	void OnCollisionEnter(Collision collision){
//		
//		if (collision.gameObject == CompareTag("Player")){
//			DestroyObject (GameObject.FindGameObjectsWithTag("Player"));
//		}
//	}

	// Use this for initialization
	void Start () {
		players = GameObject.FindGameObjectsWithTag("Player");

       // int currentZombieCounter = 0;
        //    while ( currentZombieCounter < ZombieCount ) {
         //   randomNumber = Random.Range (0,10);
			
		//		Vector3 zombiePosition = Random.insideUnitSphere * 20f;
        //        zombie newZombie = Instantiate( zombieBlueprint, zombiePosition, Quaternion.identity ) as zombie;
        //        zombieList.Add( newzombie ); 
        //        currentZombieCounter++;
		//}
        
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