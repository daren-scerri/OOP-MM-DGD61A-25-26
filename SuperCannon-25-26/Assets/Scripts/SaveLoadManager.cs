using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadManager : Singleton<SaveLoadManager>
{
   SerializedData mydata = new SerializedData();
    /* JSON format
    public void SaveData()
    {
        mydata.ser_health = GameData.PlayerHealth;
        mydata.ser_score = GameData.Score;

        //JSON saving
        string jsonToSave = JsonUtility.ToJson(mydata);
        
        Debug.Log(jsonToSave);
        Debug.Log(Application.persistentDataPath);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/SuperCannonDataDGD61A.json", jsonToSave);

    }


    public void LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/SuperCannonDataDGD61A.json"))
        {
            string loadedJSON = System.IO.File.ReadAllText(Application.persistentDataPath + "/SuperCannonDataDGD61A.json");
            mydata = JsonUtility.FromJson<SerializedData>(loadedJSON);
            GameData.Score = mydata.ser_score;
            GameData.PlayerHealth = mydata.ser_health;
        }
    }

    */

    public void SaveData()
    {
        mydata.ser_health = GameData.PlayerHealth;
        mydata.ser_score = GameData.Score;

        //BINARY saving
        BinaryFormatter mybinaryFormatter = new BinaryFormatter();
        FileStream myfile = File.Create(Application.persistentDataPath + "/SuperCannonData.save");
        mybinaryFormatter.Serialize(myfile, mydata);
        myfile.Close();
    }


    public void LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/SuperCannonData.save"))
        {
            BinaryFormatter mybinaryFormatter = new BinaryFormatter();
            FileStream myfile = File.Open(Application.persistentDataPath + "/SuperCannonData.save", FileMode.Open);
            mydata = (SerializedData)mybinaryFormatter.Deserialize(myfile);
            myfile.Close();
            GameData.Score = mydata.ser_score;
            GameData.PlayerHealth = mydata.ser_health;
        }
    }
}
