using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class End_Score : MonoBehaviour {
    public static End_Score end;
	// Use this for initialization
	void Start () {
        end = this;
        gameObject.GetComponent<Text>().text = "Score: " + Score_keeper.Score_keep.Score + "\nHiScore: " + Score_keeper.Score_keep.HiScore;
    }
}
