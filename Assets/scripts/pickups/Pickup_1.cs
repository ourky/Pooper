using UnityEngine;
using System.Collections;

public class Pickup_1 : MonoBehaviour {
    private int FallSpeed = 2;
    

    // Use this for initialization
    void Start () {
        InitialiseMovement();
    }
	
    private void InitialiseMovement()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * FallSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Destroy(other.gameObject);
            Pickup_master.PickupMaster.giveBuff(new Buff());
            Destroy(gameObject);
        }
    }
}
public class Buff
{
    private int buffNu;         //fajn bi blo da bi kej slike menal glede na cifro pa več razlicnih buffov
    private int[] buffAbility = new int[2];         //[0] kaj, [1] za kolikokrat
    private int buffDuration = 4;

    public Buff()
    {
        initBuff();
    }
    /*
    ~Buff()     //destructor
    {
        Debug.Log("Buff destroyed");
    }
    */
    private void initBuff()
    {
        //ArrayList buffs = new ArrayList();            //SPREMENI v nek list
        buffNu = Random.Range(1, 2);
        switch (buffNu)
        {
            case 1:
                setBuffAbility(1, 2);
                break;
            /*
            case 2:
                setBuffAbility(2, 2);
                break;
            */
            default:
                Debug.Log("Buff not yet implemented!!! giving default atk boost. in script Pickup_1.cs");
                setBuffAbility(1, 2);
                break;
        }
    }
    private void setBuffAbility(int kaj, int kolikokrat)      //mogoče prevec metod haha
    {
        buffAbility[0] = kaj;           //1 = atk speed, 2 = movemet speed, 3,... ?
        buffAbility[1] = kolikokrat;
    }
    public int[] readBuff()
    {
        return buffAbility;
    }
    public int getBuffDuration()
    {
        return buffDuration;
    }
}

