using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Score_keeper : MonoBehaviour {

    public static Score_keeper Score_keep;
    public int Score;                           //!!! mogoče bi blo bolje, če je private in ga dobiš prek funkcij
    public int HiScore;

    void Awake() {
        if (Score_keep == null) {
            DontDestroyOnLoad(gameObject);
            Score_keep = this;
        }
        else if(Score_keep != this){
            Destroy(gameObject);
        }
    }
    
    public void OnEnable()
    {
        Load();
        //Debug.Log(HiScore);
    }
    public void OnDisable()
    {
        Save();
    }

    public void NullScore() {
        Score = 0;
    }
    public void ChangeScore(int a) {
        if (a > HiScore)
        {
            Score = a;
            HiScore = a;
        }
        else {
            Score = a;
        }
    }
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.HiScore = HiScore;
        //data.Score = Score;

        bf.Serialize(file, data);
        file.Close();
    }
    
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);     //!!!
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            HiScore = data.HiScore;
        }
    }
}

[Serializable]
class PlayerData {
    public int HiScore;
    //public int Score;

}