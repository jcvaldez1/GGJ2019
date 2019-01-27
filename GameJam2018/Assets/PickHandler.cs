using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickHandler : MonoBehaviour, Ipickable<GameObject>, Interactable {

	public GameObject Person;
	public void isUsed(){
		// start animation
		//pickup ();
	}
	public void pickup(GameObject interActor){
		this.Person = interActor;
	}
}
