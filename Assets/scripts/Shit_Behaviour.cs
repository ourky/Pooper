using UnityEngine;
using System.Collections;

public class Shit_Behaviour : MonoBehaviour
{
    private Rigidbody2D Bullet_Rigidbody = null;
    private float acceleration = 2f;

    void Start()
    {
        Bullet_Rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    { 
        Bullet_Rigidbody.AddForce(Vector2.down * acceleration);
    }
}
