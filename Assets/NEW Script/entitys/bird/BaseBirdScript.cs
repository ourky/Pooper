using UnityEngine;
using System.Collections;

public abstract class BaseBirdScript : MonoBehaviour {
    protected GameObject thisGameObject;
    protected Rigidbody2D thisRigidBody;
	protected const float casUleta = 1.2f;
	protected const float speed = 2;
	public GameObject Bullet;

	// default vrednosti
	protected int lives = 3;
	protected int value = 10;
	protected bool alive = true;

    protected virtual void Start () {
        thisGameObject = gameObject;
        thisRigidBody = gameObject.GetComponent<Rigidbody2D>();
		StartCoroutine(entrance());	//po entrance je narjen da zacne srat
	}
	protected abstract IEnumerator shootBirdShit();
    protected abstract void onTriggerEnter2D(Collider2D other);
    protected abstract void death();
	protected IEnumerator entrance()
	{
		float endtime = Time.time + casUleta;
		thisRigidBody.velocity = Vector2.down * speed;
		yield return new WaitUntil(() => Time.time >= endtime);
		thisRigidBody.velocity = Vector2.zero;
		StartCoroutine(shootBirdShit());
	}
}
