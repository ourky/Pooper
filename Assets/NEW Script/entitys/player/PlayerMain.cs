using UnityEngine;
using System.Collections;
using System;

public class PlayerMain : MonoBehaviour,Buffable {
	public static PlayerMain playerOne;

	float[] buffEndTime = new float[2];

	void Start () {
		playerOne = this;
		for(int a = 0; a < buffEndTime.Length; a++)
		{
			buffEndTime[a] = 0;
		}
	}
	//buffs
	public void applyFireRateBuff(int duration)
	{
		if (buffEndTime[0] == 0)
		{
			buffEndTime[0] = Time.time + duration;
			StartCoroutine(fireRateBuff(duration));
		}
		else
		{
			buffEndTime[0] = Time.time + duration;
		}
	}
	public IEnumerator fireRateBuff(int duration)
	{
		PlayerShoot.fireRate = PlayerShoot.baseFireRate / 2;
		yield return new WaitUntil(() => Time.time >= buffEndTime[0]);
		PlayerShoot.fireRate = PlayerShoot.baseFireRate;
		buffEndTime[0] = 0;
	}
	public void applyMovementSpeedBuff(int duration)
	{
		if (buffEndTime[1] == 0)
		{
			buffEndTime[1] = Time.time + duration;
			StartCoroutine(movementSpeedBuff(duration));
		}
		else
		{
			buffEndTime[1] = Time.time + duration;
		}
	}
	public IEnumerator movementSpeedBuff(int duration)
	{
		PlayerMovement.speed = PlayerMovement.baseSpeed * 2;
		yield return new WaitUntil(() => Time.time >= buffEndTime[1]);
		PlayerMovement.speed = PlayerMovement.baseSpeed;
		buffEndTime[1] = 0;
	}
}
