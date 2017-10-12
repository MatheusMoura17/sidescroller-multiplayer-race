using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float speed=10;
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = transform.position;
		targetPosition.x = target.position.x;

		transform.position = Vector3.Lerp (transform.position, targetPosition, speed * Time.deltaTime);
	}
}
