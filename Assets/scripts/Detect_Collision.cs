using UnityEngine;
using System.Collections;

public class Detect_Collision : MonoBehaviour {
    private GameObject Bird = null;
	
    public int value = 10;
    public int timeInc = 4;
	private Rigidbody2D Bird_Rigidbody = null;
    
	private int speed = 2;
	private float cas = 1.2f;
	private bool hit = true;
	private bool Flydown = true;

    public int Flyup = 2;
    private int pozition = -1;

    // Use this for initialization
    void Start () {
        Bird = gameObject;
        Bird_Rigidbody = Bird.GetComponent<Rigidbody2D>();
		
		cas += Time.time;
		Game_master.master.ptici += 1;
        //func = master.GetComponent<Game_master>();
		Bird_Rigidbody.velocity = Vector2.down * speed;
    }
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= cas && Flydown) {
		Bird_Rigidbody.velocity = Vector2.zero;
		Flydown = false;
		//hit = true;
		}
	}
    void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == "Player" && hit&& !Flydown)
        {
            Destroy(other.gameObject);
			hit=false;
			Flydown = false;
            
            //funkcija ko ptič umre
            StartCoroutine(Death(Flyup));
           
        }
        
        //da ptič ve katera pozicija je zasedena
        if (other.tag == "Pozition" && pozition == -1)            // MOGOĆE BOJO PROBLEMI Z ON TRIGGER ENTER, BOLJE MOGOČE ONTRIGGER STAY
        {
            pozition = other.GetComponent<Get_Pozition>().get_pozition();
        }
    }
    IEnumerator Death(int sec)
    {
        Destroy(Bird.GetComponent<Shoot_BirdShit>());       //da ptič neha srati uničim script za srat
        Game_master.master.Add(value,timeInc);
        Game_master.master.ptici -= 1;
        Pozition_master.mast.Free_Poz(pozition);
        //Game_master.master.SpawnBird();
        //Bird_Rigidbody.velocity = Vector2.up * speed; //STARO


		Bird_Rigidbody.isKinematic = false; 			//NOVO - Koda za padajoče ptiče
		Vector2 randomVector = Random.insideUnitCircle; //NOVO
		if(randomVector.y < 0f)							//NOVO
		{
			randomVector = new Vector2(randomVector.x, -randomVector.y);
		}
		Bird_Rigidbody.AddForce(randomVector * 3f, ForceMode2D.Impulse); //NOVO
		Bird_Rigidbody.AddTorque(randomVector.magnitude * 2f, ForceMode2D.Impulse);//NOVO


        yield return new WaitForSeconds(sec);
        Destroy(gameObject);
    }
}
