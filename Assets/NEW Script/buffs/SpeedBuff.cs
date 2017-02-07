using UnityEngine;
using System.Collections;

public class SpeedBuff : BaseBuff {
    private const int baseSpeed = PlayerMovement.baseSpeed;
	private static float buffEndTime = 0;
	private static bool buffed = false;

	public override void applyBuff(Buffable zadel)
	{
		zadel.applyMovementSpeedBuff(duration);
	}
}

