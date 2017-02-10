using UnityEngine;
using System.Collections;

public class PlayerPoopBehaviour : BasicPoopBehaviour {
	protected override void Start()
	{
		speed = 4;
		base.Start();
	}
	protected override void startMovement()
	{
		thisRigidBody2d.velocity = Vector2.up * speed;
	}
}
