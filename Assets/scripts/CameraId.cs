using UnityEngine;
using System.Collections;

public class CameraId : MonoBehaviour {
    public static CameraId cameraId = null;
    private Camera cam = null;
	// Use this for initialization
	void Start () {
        cameraId = this;
        cam = gameObject.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public Camera getCam()
    {
        return cam;
    }
}
