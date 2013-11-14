using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	
	public Sheep dolly; // assign this prefab in inspector
	public TextMesh fameMeter; //assign this reference in the inspector
	
	// "static" means this variable doesn't live in teh scene
	// it means that this variable lives inside the code itself
	// 		e.g. if we made 20 copies of PlayerInput on 20 gameObjects
	//		then they would all still only reference the SAME "selectedSheep"
	public static Sheep currentSheep;
	// the reason ths is useful: you no longer have to drag and drop anything
	// and you don't have to use GetComponent because this variable lives in code
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit rayHit = new RaycastHit();
		
		//if rayhit = sheep
		if ( Physics.Raycast ( ray, out rayHit, 10000f) ) {
			
			//the 0 tells it what mouse button they have
			if ( Input.GetMouseButtonDown( 0 ) && rayHit.collider.tag == "Sheep" ) {
				//whatever code runs here is 
				// - the mouse is over a GameObject with a collider and "Sheep" tag
				// - when the mouse is left-click 
				Sheep selectedSheep = rayHit.collider.GetComponent<Sheep>();
				fameMeter.text = "sheep fame = " + selectedSheep.fame.ToString ();
				currentSheep = selectedSheep; // saves what sheep we clicked on
			}
			
			
			if (Input.GetMouseButtonDown ( 1 ) ) {
				Sheep newSheep = Instantiate ( dolly, rayHit.point, Quaternion.identity ) as Sheep;
				newSheep.fame = Random.Range( 1, 100);
			}
			
			
		}
	}
}
