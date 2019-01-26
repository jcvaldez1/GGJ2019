using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

	public float MAX_VIEW_DISTANCE = 10.0f;
	void FixedUpdate () {
		RaycastHit hit;
		if (Input.GetKeyDown(KeyCode.E) && (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, MAX_VIEW_DISTANCE))) {
			hit.transform.gameObject.GetComponent<IamObject>().Use();

		}

	}
}
