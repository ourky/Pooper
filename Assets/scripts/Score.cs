using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public static Score scor;
    // Use this for initialization

    void Awake() {
        scor = this;
    }
    void Start() {
        //textCom = gameObject.GetComponent<Text>();
    }
	
    public void Update_Score(int score) {
        //textCom.text = "Score:       " + score;
        gameObject.GetComponent<Text>().text = "Score: " + score;
    }
}
