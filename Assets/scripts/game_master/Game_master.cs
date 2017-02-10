using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game_master : MonoBehaviour {

    public static Game_master master;
	
	public int ptici = 0;           //koliko ptičev je v igri
    private int Score_am = 0;
    public int lives = 3;

	public Material heartsMat; //NOVO
	public GameObject heartsPlane; //NOVO

    private Component Score_field;

    public ArrayList pozitions = new ArrayList();

    void Awake() {
        master = this;

		heartsPlane.transform.localScale = new Vector3 (1f, (float) lives, 1f); //NOVO
		heartsMat.mainTextureScale = new Vector2 ((float)lives, 1f); //NOVO
    }

    void Start() {
        Score.scor.Update_Score(Score_am);
        Score_keeper.Score_keep.NullScore();
        //UpdateLives(lives);
    }

    //LIVES
    public void Add(int value)
    {   
        Score_am += value;
        //Clock.cl.IncreaseTime(timeInc);
        Score.scor.Update_Score(Score_am);
        Score_keeper.Score_keep.ChangeScore(Score_am);
    }
    public void ChangeLives(int change) {
        lives += change;

		heartsPlane.transform.localScale = new Vector3 (1f, (float) lives, 1f); //NOVO
		heartsMat.mainTextureScale = new Vector2 ((float)lives, 1f); //NOVO

        if (lives == 0)
        {
            SceneManager.LoadScene("death");
        }/*
        else {
            UpdateLives(lives);
        }*/
    }
    public void gameOver() {
        SceneManager.LoadScene("death");
    }
}
