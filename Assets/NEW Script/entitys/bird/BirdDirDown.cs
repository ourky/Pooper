using UnityEngine;
using System.Collections;
using System;

public class BirdDirDown : BaseBirdScript {

	protected override void Start () {
		base.Start();
	}
	protected override void death()
	{
		throw new NotImplementedException();
	}

	protected override void onTriggerEnter2D(Collider2D other)
	{
		throw new NotImplementedException();
	}

	protected override IEnumerator shootBirdShit()
	{
		while (alive)
		{

		}
	}
	
}
