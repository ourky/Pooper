using UnityEngine;
using System.Collections;

public class BaseBirdScript : MonoBehaviour
{
	protected GameObject thisGameObject;
	protected Rigidbody2D thisRigidBody;
	public GameObject Bullet;
	// stevilka pozicije ptica, uporablja za spawnanje
	private int pozitionNumber;

	// default vrednosti
	protected int lives = 1;
	protected int value = 10;
	protected bool alive = true;
	protected float firerate = 1.5f;
	protected const float casUleta = 1.2f;
	protected const float speed = 2;
	//zacetna pozicija ptica
	protected Vector2 pozicija;
	// po kokih sekundah po smrti ga zbriše
	protected float deleteAfter = 4;

	protected virtual void Start ()
	{
		thisGameObject = gameObject;
		thisRigidBody = gameObject.GetComponent<Rigidbody2D> ();
		StartCoroutine (entrance ());	//po entrance je narjen da zacne srat
	}

	protected IEnumerator entrance ()
	{
		float endtime = Time.time + casUleta;
		thisRigidBody.velocity = Vector2.down * speed;
		yield return new WaitUntil (() => Time.time >= endtime);
		thisRigidBody.velocity = Vector2.zero;
		pozicija = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y - 0.35f);   //setta se pozicija od kje serje
		StartCoroutine (shootBirdShit ());
	}

	protected virtual void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player" && alive) {
			lives--;
			Destroy (other.gameObject);
			if (lives <= 0) {
				StartCoroutine (death ());
			}
		}
	}

	protected virtual IEnumerator shootBirdShit ()
	{
		while (alive) {
			//lahko damo fiksno pozicijo, k se ptic ne premika levo in desno po instantiranju
			Instantiate (Bullet, pozicija, new Quaternion (0, 0, 0, 0));
			yield return new WaitForSeconds (firerate);
		}
	}

	protected virtual IEnumerator death ()
	{
		thisRigidBody.isKinematic = false;

		alive = false;
		GameMaster.master.addPoints (value);  
		Vector2 randomVector = Random.insideUnitCircle; 
		if (randomVector.y < 0f) {
			randomVector = new Vector2 (randomVector.x, -randomVector.y);
		}
		thisRigidBody.AddForce (randomVector * 3f, ForceMode2D.Impulse); 
		thisRigidBody.AddTorque (randomVector.magnitude * 2f, ForceMode2D.Impulse);
		yield return new WaitForSeconds (deleteAfter);
		Destroy (gameObject);
	}

	// se uporabljajo za random spawnanje
	private void freePozition ()
	{
		SpawnMaster.freePozition (pozitionNumber);
	}

	public void asignPozition (int pozition)
	{
		pozitionNumber = pozition;
	}
}
