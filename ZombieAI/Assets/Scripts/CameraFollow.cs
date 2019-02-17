using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;
	private Vector3 position;

	void FixedUpdate(){
		position.x = target.position.x;
		position.y = target.position.y;
		Vector3 desirePosition = position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
		transform.position = smoothedPosition;
	}

}
