using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Wait_for(4));
	}
	
    IEnumerator Wait_for(int sec) {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("Menu");
    }
}
