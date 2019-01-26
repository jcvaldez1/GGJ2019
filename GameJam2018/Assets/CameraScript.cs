using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public Vector3 smoothSpeed = Vector3.one;
	public Vector3 offset = Vector3.zero;


	void FixedUpdate () {
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.SmoothDamp (transform.position, desiredPosition,ref smoothSpeed, 0.01f, 1000.0f);
		transform.position = smoothedPosition;
		transform.rotation = target.rotation;
	}
}
