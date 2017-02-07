using UnityEngine;
using System.Collections;

public interface Buffable{
	void applyFireRateBuff(int duration);
	IEnumerator fireRateBuff(int duration);
	void applyMovementSpeedBuff(int duration);
	IEnumerator movementSpeedBuff(int duration);
}
