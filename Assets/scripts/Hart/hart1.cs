using UnityEngine;
using System.Collections;

public class hart1 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
		if (Game_master.master.lives < 3)
        {
            Destroy(gameObject);
        }
	
	}
}