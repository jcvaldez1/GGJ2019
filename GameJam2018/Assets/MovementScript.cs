using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	// Use this for initialization
	#region "Variables"
	public Rigidbody Rigid;
	public float MouseSensitivity;
	public float MoveSpeed;
	public float JumpForce;
	#endregion


	void Update ()
	{
		Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(-1*Input.GetAxis("Mouse Y") * MouseSensitivity, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
		Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
		if (Input.GetKey ("space")) {
			Rigid.AddForce(transform.up * JumpForce);
		}

	}

}
