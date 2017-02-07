using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour{
    private Touch[] touchlist;
    private double blokada = 2.6;
    private Rigidbody2D objectRigidbody = null;
    public bool mobile;
    public static int speed = 2;
    public const int baseSpeed = 2;

    private double Screen_Width_Half;

    // za mobile, da najde robove
    private Camera cam = null;
    private Vector3 topRightPoint;
    private Vector3 lowLeftPoint;

    void Start()
    {
        objectRigidbody = gameObject.GetComponent<Rigidbody2D>();
        Screen_Width_Half = Screen.width / 2;
        // za ugotavljanje mej
        cam = Camera.main;
        topRightPoint = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        lowLeftPoint = cam.ScreenToWorldPoint(new Vector3(0, 0, 0));
    }

    void Update () {
        if (!mobile)
        {
            if (Input.GetKey(KeyCode.A) && transform.position.x > -blokada)
            {
                objectRigidbody.velocity = Vector2.left * speed;
            }
            else if (Input.GetKey(KeyCode.D) && transform.position.x < blokada)
            {
                objectRigidbody.velocity = Vector2.right * speed;
            }
            else
            {
                objectRigidbody.velocity = Vector2.zero;
            }
        }

        else if (mobile)
        {
            if (Input.touchCount > 0)
            {
                touchlist = Input.touches;
                foreach (Touch finger in touchlist)
                {
                    if (finger.rawPosition.x < Screen_Width_Half && transform.position.x > lowLeftPoint.x - Screen.width / 5)
                    {
                        objectRigidbody.velocity = Vector2.left * speed;
                    }
                    else if (finger.rawPosition.x > Screen_Width_Half && transform.position.x < topRightPoint.x + Screen.width / 5)
                    {
                        objectRigidbody.velocity = Vector2.right * speed;
                    }
                    else
                    {
                        objectRigidbody.velocity = Vector2.zero;
                    }
                }
            }
            else
            {
                objectRigidbody.velocity = Vector2.zero;
            }

        }
        else
        {
            Debug.Log("NAPAKA! v Player movement, noben mode nekak ni aktiven??");
        }
    }
}
