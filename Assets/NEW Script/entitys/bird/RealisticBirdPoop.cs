using UnityEngine;
using System.Collections;

public class RealisticBirdPoop : BasicPoopBehaviour {
	protected override void startMovement()
	{
		StartCoroutine(padanje());
	}
	private IEnumerator padanje()
	{
		while (true)
		{
			thisRigidBody2d.AddForce(Vector2.down * speed);
			yield return null;
		}
	}
}
