using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    public const float baseFireRate = 0.7f;
    public static float fireRate;
    private float nextFire = 1.5f;
    private float pocaki = 2f;
    private Vector2 playerPosition;

    public GameObject Bullet = null;

    private void Start()
    {
        playerPosition = gameObject.transform.position;
		fireRate = baseFireRate;
    }
    private void FixedUpdate()
    {
        playerPosition = gameObject.transform.position;
        Vector2 bulletPosition = new Vector2(playerPosition.x, playerPosition.y);

        if (Time.time >= nextFire && Time.time >= pocaki)
        {
			//Debug.Log("shoot " + PlayerShoot.fireRate );
			Instantiate(Bullet, bulletPosition, new Quaternion(0, 0, 0, 0));
            nextFire = Time.time + fireRate;
        }

    }

}
