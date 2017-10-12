using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public float speed=300;
	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;
	
	// Update is called once per frame
	void Update () {
		JointMotor2D backMotor = backWheel.motor;
		JointMotor2D frontMotor = frontWheel.motor;

		backMotor.motorSpeed=speed * -Input.GetAxis ("Vertical");
		frontMotor.motorSpeed=speed * -Input.GetAxis ("Vertical");

		backWheel.motor = backMotor;
		frontWheel.motor = frontMotor;
	}
}
