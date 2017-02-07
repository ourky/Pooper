using UnityEngine;
using System.Collections;

public class Bullet_Behaviour : MonoBehaviour {
    private Rigidbody2D Bullet_Rigidbody = null;
    private int speed = 3;
	// Use this for initialization
	void Start () 
	{
        Bullet_Rigidbody = gameObject.GetComponent<Rigidbody2D>();
        Bullet_Rigidbody.velocity = Vector2.up * speed;
	}
}
