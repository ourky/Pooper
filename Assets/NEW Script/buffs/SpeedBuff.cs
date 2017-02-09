using UnityEngine;
using System.Collections;

public class SpeedBuff : BaseBuff {

	public override void applyBuff(Buffable zadel)
	{
		zadel.applyMovementSpeedBuff(duration);
	}
}

