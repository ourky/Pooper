using UnityEngine;
using System.Collections;

public class Player_DetectCollision : MonoBehaviour {
    //int HitCount = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bird")
        {
            Handheld.Vibrate();
			Destroy(other.gameObject);
			Game_master.master.ChangeLives(-1);
			
        }
    }
}
