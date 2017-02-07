using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour
{

	public bool Mobile;

	private GameObject Player = null;
	//private Vector3 Player_Position;
	private Rigidbody2D Player_Rigidbody = null;
	private int Screen_Width_Half;
	public int speed = 200;
	private Touch finger;
	private Touch[] touchlist;
	private double blokada = 2.6;

    private Camera cam = null;
    private Vector3 topRightPoint;
    private Vector3 lowLeftPoint;

    // Use this for initialization
    void Start ()
	{
		Player = gameObject;
		Player_Rigidbody = Player.GetComponent<Rigidbody2D> ();
		//Player_Position = Player.transform.position;
		Screen_Width_Half = Screen.width / 2;
        cam = Camera.main;
        topRightPoint = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        lowLeftPoint = cam.ScreenToWorldPoint(new Vector3(0, 0, 0));
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (!Mobile) 
		{
			if (Input.GetKey (KeyCode.A) && transform.position.x > -blokada) 
			{
				Player_Rigidbody.velocity = Vector2.left * speed;
			}
			else if (Input.GetKey (KeyCode.D) && transform.position.x < blokada) 
			{
				//Player_Rigidbody.AddForce(Vector2.right * speed);
				Player_Rigidbody.velocity = Vector2.right * speed;
			}
			else
			{
				Player_Rigidbody.velocity = Vector2.zero;
			}
		}

		else if (Mobile) 
		{
			if(Input.touchCount>0)
			{
			touchlist = Input.touches;
			    foreach (Touch finger in touchlist) {
                    //sem spremenil, da ne bo vedno na novo ugotavljal; v if sem namesto Screen.width / 2 dal int, kjer je ta vrednost shranjena
                    //tnx brt
                    /*
				    if (finger.rawPosition.x < Screen_Width_Half && transform.position.x > -blokada) {
					    Player_Rigidbody.velocity = Vector2.left * speed;
				    } else if (finger.rawPosition.x > Screen_Width_Half && transform.position.x < blokada) {
					    Player_Rigidbody.velocity = Vector2.right * speed;
				    }
                    */
                    if (finger.rawPosition.x < Screen_Width_Half && transform.position.x > lowLeftPoint.x -Screen.width/5)
                    {
                        Player_Rigidbody.velocity = Vector2.left * speed;
                    }
                    else if (finger.rawPosition.x > Screen_Width_Half && transform.position.x < topRightPoint.x + Screen.width/5)
                    {
                        Player_Rigidbody.velocity = Vector2.right * speed;
                    }
                    else
                    {
                        Player_Rigidbody.velocity = Vector2.zero;
                    }
                }
			}
			else
			{
				Player_Rigidbody.velocity = Vector2.zero;
			}
			
		}
        else
        {
            Debug.Log("NAPAKA! v Player movement, noben mode nekak ni aktiven??");
        }
	}
}
