using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

    public static Lives liv;


 /*
------------------------

A ta script sploh rabmo?

------------------------
*/

	void Awake () 
	{
        liv = this;	
	}

    public void UpdateLives(int lives) {

        gameObject.GetComponent<Text>().text = "Lives:      " + lives; 

    }
}
