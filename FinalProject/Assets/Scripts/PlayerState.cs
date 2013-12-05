using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {

	public bool isZombie = false;

	public GameObject otherPlayer;



	void Update () {
		if ( isZombie ) {
			renderer.material.SetColor("_Color", Color.black);
			//if other player is zombie too, you lose
			//put zombie mesh on
			//disable normal movement & enable zombie movement
			//make him a trigger somehow so that he can kill other player
		}

		else {
			renderer.material.SetColor ("_Color", Color.white);
		}
	}
}