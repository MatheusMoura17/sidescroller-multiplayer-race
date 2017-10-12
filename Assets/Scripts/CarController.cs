using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
	public float speed=300;
	public float rotateSpeed=0.5f;
	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;
	public Rigidbody2D myRigdbody2D;
	
	void Start(){
		myRigdbody2D = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		JointMotor2D backMotor = backWheel.motor;
		JointMotor2D frontMotor = frontWheel.motor;

		backMotor.motorSpeed=speed * -Input.GetAxis ("Vertical");
		frontMotor.motorSpeed=speed * -Input.GetAxis ("Vertical");

		backWheel.motor = backMotor;
		frontWheel.motor = frontMotor;

		myRigdbody2D.AddTorque (backMotor.motorSpeed * rotateSpeed * Input.GetAxis ("Horizontal"));
	}
}
