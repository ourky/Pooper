using UnityEngine;
using System.Collections;
using System;

public class FireRateBuff : BaseBuff
{
	public override void applyBuff(Buffable zadel)
	{
		zadel.applyFireRateBuff(duration);
	}
}
