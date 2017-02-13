using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	public static GameMaster master = null;
	private long points = 0;

	void Start()
	{
		master = this;
	}
	public void addPoints(int value)
	{
		points += value;
	}
}
