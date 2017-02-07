using UnityEngine;
using System.Collections;
using System.Threading;


public class Shoot_BirdShit : MonoBehaviour
{
    public GameObject ShitBullet = null;
    
    private float Firerate =1.5f;
    private float NextFire = 1.5f;

    // Use this for initialization
    void Start()
    {
		NextFire += Time.time;
		
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= NextFire)
        {

			Instantiate(ShitBullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.35f), Quaternion.identity);
            NextFire = Time.time + Firerate + Random.Range(0.0f, 1.0f);
        }

    }
    //ko bo ptič zadet, bom zbrisal script za streljat z njega
	/*
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Bird")
        {
            Shit = false;
           
        }
		
    }
    */
}
