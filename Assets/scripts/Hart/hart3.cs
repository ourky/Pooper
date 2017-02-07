using UnityEngine;
using System.Collections;

public class hart3 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
		if (Game_master.master.lives < 1)
        {
            Destroy(gameObject);
        }
	
	}
}