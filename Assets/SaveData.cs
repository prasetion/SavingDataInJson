using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [SerializeField] private PotionData _PotionData = new PotionData();

    public void SaveIntoJson(){
        Debug.LogWarning(Application.persistentDataPath);
        Debug.LogWarning(Application.systemLanguage);
        string potion = JsonUtility.ToJson(_PotionData);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PotionData.json", potion);
    }
}

[System.Serializable]
public class PotionData{
    public string potion_name;
    public int value;
    public List<Effect> effect = new List<Effect>();
}

[System.Serializable]
public class Effect{
    public string name;
    public string desc;
}


