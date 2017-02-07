using UnityEngine;
using System.Collections;
using System;

public abstract class BaseBuff : MonoBehaviour {
    private const float fallSpeed = 2f;
    public const int duration = 1;

    void Start () {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * fallSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
			try {
				Buffable zadel = PlayerMain.playerOne;
				applyBuff(zadel);
			}
			catch(NullReferenceException kaj)
			{
				throw new NullReferenceException(kaj + " ,verjetno ni skripta na objektu");
			}
			Destroy(gameObject);
        }
    }
    public abstract void applyBuff(Buffable zadel);
}
