using UnityEngine;
using System.Collections;

public class hart2 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
		if (Game_master.master.lives < 2)
        {
            Destroy(gameObject);
        }
	
	}
}