using UnityEngine;
using System.Collections;

public class BasicPoopBehaviour : MonoBehaviour {
	protected float speed = 2;
	protected Rigidbody2D thisRigidBody2d;

	protected virtual void Start()
	{
		thisRigidBody2d = gameObject.GetComponent<Rigidbody2D>();
		startMovement();
	}
	protected virtual void startMovement()
	{
		thisRigidBody2d.velocity = Vector2.down * speed;
	}
}
