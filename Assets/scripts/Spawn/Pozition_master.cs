using UnityEngine;
using System.Collections;

public class Pozition_master : MonoBehaviour {

    public static Pozition_master mast;

    public GameObject pozition_1;
    public GameObject pozition_2;
    public GameObject pozition_3;
    public GameObject pozition_4;
    public GameObject pozition_5;

    public GameObject Bird;
    public float NextBird;
    public float BirdRate = 2f;

    ArrayList availab_poz = new ArrayList();          //proste pozicije

    // Use this for initialization
    void Start () {
        mast = this;
        initialize_pozitions();
        //SpawnBird();
        NextBird = Time.time;
    }
    void FixedUpdate()
    {
        if (Time.time >= NextBird)
        {
            SpawnBird();
            NextBird = Time.time + BirdRate;
        }

    }

    void initialize_pozitions()
    {
        pozition_1.GetComponent<Get_Pozition>().set_pozition(1);
        pozition_2.GetComponent<Get_Pozition>().set_pozition(2);
        pozition_3.GetComponent<Get_Pozition>().set_pozition(3);
        pozition_4.GetComponent<Get_Pozition>().set_pozition(4);
        pozition_5.GetComponent<Get_Pozition>().set_pozition(5);
        //da da so vse proste
        availab_poz.Add(1);
        availab_poz.Add(2);
        availab_poz.Add(3);
        availab_poz.Add(4);
        availab_poz.Add(5);
    }
    public void SpawnBird()     //ne vem če je popolnoma random
    {
        if (availab_poz.Count > 0)      //da ne bo iskal če ni frei pozicij
        {
            int ran;

            ran = Random.Range(0, availab_poz.Count - 1);

            int poz = (int)availab_poz[ran];

            if (poz == 1)
                Instantiate(Bird, new Vector2(pozition_1.transform.position.x, 5.51f), new Quaternion(0, 0, 0, 0));
            if (poz == 2)
                Instantiate(Bird, new Vector2(pozition_2.transform.position.x, 5.51f), new Quaternion(0, 0, 0, 0));
            if (poz == 3)
                Instantiate(Bird, new Vector2(pozition_3.transform.position.x, 5.51f), new Quaternion(0, 0, 0, 0));
            if (poz == 4)
                Instantiate(Bird, new Vector2(pozition_4.transform.position.x, 5.51f), new Quaternion(0, 0, 0, 0));
            if (poz == 5)
                Instantiate(Bird, new Vector2(pozition_5.transform.position.x, 5.51f), new Quaternion(0, 0, 0, 0));

            availab_poz.RemoveAt(ran);
        }
    }
    public void Free_Poz(int poz)
    {
        availab_poz.Add(poz);
    }
}
