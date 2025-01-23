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

    public List<ItemData> itemDataList = new List<ItemData>();


    void Start()
    {
        itemDataList = GameObject.FindGameObjectWithTag("DataManager").GetComponent<DataManager>().itemDataList;

        InstatiateItems();
    }

    void InstatiateItems()
    {
        for (int i = 0; i < itemDataList.Count; i++)
        {
            ItemData itemData = itemDataList[i];
            GameObject itemObject = Instantiate(defaultActivityItemPrefab, contentObj.transform);
            itemObject.transform.position = new Vector2(0f, itemObject.transform.position.y + (i * (-120)) + 300);
            CalendarItem item = itemObject.GetComponent<CalendarItem>();
            item.Initialize(itemData.header, itemData.description, itemData.date, itemData.smallImg, i);
        }
    }
}