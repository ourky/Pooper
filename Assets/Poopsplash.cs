using UnityEngine;
using System.Collections;

public class Poopsplash : MonoBehaviour {
	private float cas = 1f;
	// Use this for initialization
	void Start () {
	    cas += Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time >= cas)
	    {
	
	    Destroy(gameObject);
	    }
	}
}
