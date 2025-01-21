using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CalendarPage : MonoBehaviour
{
    public GameObject defaultActivityItemPrefab;
    public GameObject contentObj;
    public ItemDataList itemDataList;

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

    [CreateAssetMenu(fileName = "ItemDataList", menuName = "ScriptableObjects/ItemDataList", order = 1)]
    public class ItemDataList : ScriptableObject
    {
        public ItemData[] items;
    }

    void Start()
    {
        InstatiateItems();
    }

    void InstatiateItems()
    {
        for (int i = 0; i < itemDataList.items.Length; i++)
        {
            ItemData itemData = itemDataList.items[i];
            GameObject itemObject = Instantiate(defaultActivityItemPrefab, contentObj.transform);
            itemObject.transform.position = new Vector2(0f, itemObject.transform.position.y + (i * (-120)) + 300);
            CalendarItem item = itemObject.GetComponent<CalendarItem>();
            item.Initialize(itemData.header, itemData.description, itemData.date, itemData.smallImg, i);
        }
    }
}
