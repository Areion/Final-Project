using UnityEngine;
using System.Collections;

public class Sheep : MonoBehaviour {
	
	// "public" does 2 things
	// access in the editor, on per-sheep basis
	// it lets other scripts access this varibale
	public int fame = 10;
	
	
	//first I need a reference to the particle system component
	public ParticleSystem fameParticles; //assign this in inspector
	
	// Use this for initialization
	void Start () {
	
		// the sheep will spit out particles relative to their fame count
		fameParticles.emissionRate = fame;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		// if we are the current sheep, enable particles; otherwise, turn off
		if ( PlayerInput.currentSheep == this ) {
			fameParticles.enableEmission = true;
		} else {
			fameParticles.enableEmission = false;
		}
	}
}
