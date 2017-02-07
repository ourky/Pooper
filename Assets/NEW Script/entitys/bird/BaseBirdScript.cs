using UnityEngine;
using System.Collections;

public abstract class BaseBirdScript : MonoBehaviour {
    protected GameObject thisGameobject;
    protected Rigidbody2D thisRigidBody;
    protected int lives;

    protected virtual void Start () {
        thisGameobject = gameObject;
        thisRigidBody = thisGameobject.GetComponent<Rigidbody2D>();
	}
    protected abstract void onTriggerEnter2D(Collider2D other);
    protected abstract void death();
}
