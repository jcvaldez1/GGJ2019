using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IamObject : MonoBehaviour{

	public bool used; // FOR WHEN THE OBJECT IS ALREADY USED
	public bool reusable;
	public GameObject Alternate;
	public GameObject current;
	public int tasknumber;

	void Start() {
	
	}

	public void Use() {
		if (reusable || !used) {
			used = !used;
			Vector3 current_position =  transform.position;
			// spawn Alternate prefab here

			// destroy current
			Destroy(this.gameObject);

			GameObject temp = current;
			current = Alternate;
			Alternate = temp;


			Debug.Log ("HELLO");
			GameObject newboi = GameObject.Instantiate (current);
			newboi.transform.position = current_position;
			// render current,  in curren_position

			// open checklist that this object has been done
			
		}
	}

	public void requirementCheck(bool check) {
		if (check) {
			Use ();
		}
	}
}
