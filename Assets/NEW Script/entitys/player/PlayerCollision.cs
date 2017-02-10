using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {
    private static int startLives = 3;
    
	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Bird")
		{
			Destroy(other.gameObject);
			startLives--;
			if (startLives <= 0)
				death();
		}
	}
	private void death()
	{
		SceneManager.LoadScene(3); //death scene
	}
}
