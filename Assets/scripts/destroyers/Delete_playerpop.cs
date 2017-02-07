using UnityEngine;
using System.Collections;

public class Delete_playerpop : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
