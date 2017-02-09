using UnityEngine;
using System.Collections;

public abstract class BaseBirdScript : MonoBehaviour {
    protected GameObject thisGameObject;
    protected Rigidbody2D thisRigidBody;
    protected int lives;
	protected int value;


    protected virtual void Start () {
        thisGameObject = gameObject;
        thisRigidBody = gameObject.GetComponent<Rigidbody2D>();
		StartCoroutine(shootBirdShit());
	}
	protected abstract IEnumerator shootBirdShit();
    protected abstract void onTriggerEnter2D(Collider2D other);
    protected abstract void death();
}
