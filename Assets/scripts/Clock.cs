using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Clock : MonoBehaviour {
    public static Clock cl;
    public float remTime = 40;

	// Use this for initialization
	void Awake () {
        cl = this;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        remTime -= Time.deltaTime;
        gameObject.GetComponent<Text>().text = "Time: " + (int)remTime;

        if (remTime <= 0) {
            Game_master.master.gameOver();
        }
    }
    public void IncreaseTime(int incTime) {
        remTime += incTime;

    }
}
