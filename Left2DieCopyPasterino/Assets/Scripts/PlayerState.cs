using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {
	public bool isZombie = false;
	bool wasZombie1FrameAgo = false;
	public bool justTurnedToZombie = false;
	public bool justTurnedToHuman = false;
	public GameObject otherPlayer;

	void Update () {

		if ( isZombie && wasZombie1FrameAgo == false ) justTurnedToZombie = true;
		else justTurnedToZombie = false;
		if ( isZombie == false && wasZombie1FrameAgo ) justTurnedToHuman = true;
		else justTurnedToHuman = false;

		if ( justTurnedToZombie ) {
			Transform[] bodyForms = GetComponentsInChildren<Transform>(); 
			foreach ( Transform bodyForm in bodyForms ) {
				if ( bodyForm.tag == "HumanForm" ) changeVisibility( bodyForm, false );
				else if ( bodyForm.tag == "ZombieForm" ) changeVisibility( bodyForm, true );
			}
		}

		if ( justTurnedToHuman ) {
			Transform[] bodyForms = GetComponentsInChildren<Transform>(); 
			foreach ( Transform bodyForm in bodyForms ) {
				if ( bodyForm.tag == "HumanForm" ) changeVisibility( bodyForm, true );
				else if ( bodyForm.tag == "ZombieForm" ) changeVisibility( bodyForm, false );
			}
		}

		if ( isZombie && otherPlayer.GetComponent<PlayerState>().isZombie == true ) {
			Application.LoadLevel (4);
		}

		wasZombie1FrameAgo = isZombie;
	}

	void changeVisibility( Transform body, bool makeVisible ) {
		Renderer[] bodyParts = body.GetComponentsInChildren<Renderer>(); 
		foreach ( Renderer bodyPart in bodyParts ) {
			bodyPart.enabled = makeVisible;
		}
	}
}