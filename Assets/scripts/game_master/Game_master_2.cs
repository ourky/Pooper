using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game_master_2 : MonoBehaviour          //SAMO ZA TESTE!!! vedno uporabljaj original
{

    public static Game_master_2 master;

    public int ptici = 0;           //koliko ptičev je v igri
    private int Score_am = 0;
    public int lives = 3;
    private Component Score_field;

    void Awake()
    {
        master = this;
    }

    void Start()
    {
        Score.scor.Update_Score(Score_am);
        Score_keeper.Score_keep.NullScore();
        //UpdateLives(lives);
    }

    //LIVES
    public void Add(int value)
    {
        Score_am += value;
        Score.scor.Update_Score(Score_am);
        Score_keeper.Score_keep.ChangeScore(Score_am);
    }
    public void ChangeLives(int change)
    {
        lives += change;

        if (lives == 0)
        {
            SceneManager.LoadScene("death");
        }/*
        else {
            UpdateLives(lives);
        }*/
    }
}
