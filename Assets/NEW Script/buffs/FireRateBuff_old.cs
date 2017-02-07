using UnityEngine;
using System.Collections;
using System;

public class FireRateBuff_old : BaseBuff {
    private const float baseSpeed = PlayerShoot.baseFireRate;
	private static float buffEndTime = 0;
	private static bool buffed = false;
	
	public override void applyBuff(Buffable zadel)
	{
		buffEndTime = duration + Time.time; 
		if (!buffed)
		{
			StartCoroutine(buff());
		}
		else{
			Destroy(gameObject);
		}
	}
	private IEnumerator buff()
	{
		buffed = true;
		PlayerShoot.fireRate = baseSpeed /2;
		Destroy(gameObject.GetComponent<CircleCollider2D>());
		Destroy(gameObject.GetComponent<SpriteRenderer>());
		yield return new WaitUntil(() => Time.time >= buffEndTime);
		PlayerShoot.fireRate = baseSpeed;
		buffed = false;
		Destroy(gameObject);
	}
}
