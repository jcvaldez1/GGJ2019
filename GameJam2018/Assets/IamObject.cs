using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IamObject : MonoBehaviour{

	public bool used; // FOR WHEN THE OBJECT IS ALREADY USED
	public bool reusable;
	public bool firstUsed;
	public Interactable actionDefns;
	public void Use() {
		if (reusable || !firstUsed) {
			used = !used;
			firstUsed = false;
			actionDefns.isUsed ();
		}
	}
}
