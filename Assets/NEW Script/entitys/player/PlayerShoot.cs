using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    public const float baseFireRate = 0.7f;
    public static float fireRate;
    private float pocaki = 2f;
    private Vector2 playerPosition;

    public GameObject Bullet = null;

    private void Start()
    {
        playerPosition = gameObject.transform.position;
		fireRate = baseFireRate;
		StartCoroutine(wait()); // po nekem delayu zacne strelat
    }
	private IEnumerator wait()
	{
		yield return new WaitForSeconds(pocaki);
		StartCoroutine(shoot());
	}
	private IEnumerator shoot()
	{
		while (true)
		{
			playerPosition = gameObject.transform.position;
			Vector2 bulletPosition = new Vector2(playerPosition.x, playerPosition.y);
			Instantiate(Bullet, bulletPosition, new Quaternion(0, 0, 0, 0));
			yield return new WaitForSeconds(fireRate);
		}
	}
}
