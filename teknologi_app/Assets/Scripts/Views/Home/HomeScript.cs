using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    public GameObject[] nameTxt;

    public List<int> comingAcceptedEvents;

    void Start()
    {
        comingAcceptedEvents = new List<int>();

        nameTxt = GameObject.FindGameObjectsWithTag("NameTxt");
        foreach (GameObject go in nameTxt)
        {
            go.GetComponent<TMP_Text>().text = PlayerPrefs.GetString("Name").ToUpper();
        }
    }
}
