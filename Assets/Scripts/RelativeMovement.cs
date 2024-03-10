using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class RelativeMovement : MonoBehaviour {
	[SerializeField] Transform target;
	
	public float moveSpeed = 6.0f;
	public float rotSpeed = 15.0f;
	public float jumpSpeed = 15.0f;
	public float gravity = -9.8f;
	public float terminalVelocity = -20.0f;
	public float minFall = -1.5f;
	public float pushForce = 3.0f;

	private float vertSpeed;
	private ControllerColliderHit contact;

	private CharacterController charController;

	void OnControllerColliderHit(ControllerColliderHit hit) {
		contact = hit;
		
		Rigidbody body = hit.collider.attachedRigidbody;
		if (body != null && !body.isKinematic) {
			body.velocity = hit.moveDirection * pushForce;
		}
	}
}
