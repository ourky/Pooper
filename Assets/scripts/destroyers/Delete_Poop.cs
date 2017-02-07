using UnityEngine;
using System.Collections;

public class Delete_Poop : MonoBehaviour {
	public GameObject Poopsplash = null;

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(Poopsplash, new Vector2(other.transform.position.x, -3.888f), new Quaternion(0, 0, 0, 0));
		Destroy(other.gameObject);
    }
}
