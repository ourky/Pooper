using UnityEngine;
using System.Collections;

public class Get_Pozition : MonoBehaviour {

    private int number;
    
    public void set_pozition(int pozition)      //dodeli pozicijo
    {
        number = pozition;
    }

    public int get_pozition()       //ptič dobi pozicijo
    {
        return number;
    }
}
