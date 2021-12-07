using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class q4b : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
        SaveData saveData = DataManager.instance.Load();
        
        if(saveData.collection_bird[4]==1){
            text.enabled = false;
        }
        else{
            text.enabled = true;
        }
    }

}