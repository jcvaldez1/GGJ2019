using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSetter : MonoBehaviour {

	void Start () {
		Material tester = this.GetComponent<Material> ();
		tester.SetColor ("_Color", Color.green);
	}

}
