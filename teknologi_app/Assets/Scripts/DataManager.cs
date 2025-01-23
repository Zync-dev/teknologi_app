using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<ItemData> itemDataList = new List<ItemData>();

    private void Start()
    {
        
    }
}

[System.Serializable]
public class ItemData
{
    public string header;
    public string description;
    public string date;
    public string location;
    public float price;

    public Sprite smallImg;
    public Sprite largeImg;
}
