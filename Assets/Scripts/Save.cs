using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
public class Save : MonoBehaviour
{
    public static Save Instance ;

    public int Score;
    public string Name,nameHolder;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    [System.Serializable]
   public class PlayerList
    {
        SaveData[] PlayersData;
    }


    [System.Serializable]
    class SaveData
    {
        public string Name;
        public int Score;

    }


    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.Name = Name;
        data.Score  = Score;
           

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json",json);

 
}

 

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            Name = data.Name;
            Score = data.Score;
          
        }
    }



    public void SaveToPlayersData()
    {
        PlayerList playerList = new PlayerList();

    }

}
