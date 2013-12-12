using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AntidoteSpawner : MonoBehaviour {
	int howMany = 3;
	public GameObject antidote;
	public List<GameObject> AntidoteList = new List<GameObject>();
	
	GameObject Player1;
	GameObject Player2;

	void Start () {
		Player1 = GameObject.FindWithTag("Player1");
		Player2 = GameObject.FindWithTag("Player2");
	}

	void Update () {
		
		// SPAWN ANTIDOTES WHEN PLAYER ZOMBIFIES
		if ( Player1.GetComponent<PlayerState>().justTurnedToZombie || Player2.GetComponent<PlayerState>().justTurnedToZombie ) {
			for ( int i=0; i<howMany; i++ ) {
				float x = Random.Range (-374f, 367f);
				float z = Random.Range (-195f, 217f);
				Vector3 antidotePosition = new Vector3( x, antidote.transform.position.y, z);	
				GameObject newAntidote = Instantiate( antidote, antidotePosition, Quaternion.identity ) as GameObject;	
				AntidoteList.Add( newAntidote );
			}
		}
		
		// DESTROY ANTIDOTES WHEN PLAYER HEALS
		if ( Player1.GetComponent<PlayerState>().justTurnedToHuman || Player2.GetComponent<PlayerState>().justTurnedToHuman ) {
			for ( int i=0; i<AntidoteList.Count; i++ ) Destroy (AntidoteList[i]);
		}
	}
}
