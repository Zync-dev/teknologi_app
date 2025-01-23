using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CalendarChosenPage : MonoBehaviour
{
    public int chosenPageId;

    public TMP_Text headerText;
    public TMP_Text descriptionText;
    public TMP_Text informationText;

    public Button tilmeldBtn;

    public Image logoImg;

    List<ItemData> itemDataList = new List<ItemData>();

    private bool signedUp = false;

    private NotificationManager notificationManager;

    private void Start()
    {
        notificationManager = GameObject.Find("NotificationManager").GetComponent<NotificationManager>();

        itemDataList = GameObject.FindGameObjectWithTag("DataManager").GetComponent<DataManager>().itemDataList;

        for(int i = 0; i < itemDataList.Count; i++)
        {
            print(itemDataList[i].header);
        }

        headerText.text = itemDataList[chosenPageId].header;
        descriptionText.text = itemDataList[chosenPageId].description;
        informationText.text = $"Dato: {itemDataList[chosenPageId].date}\nLokation: {itemDataList[chosenPageId].location}\nPris: {itemDataList[chosenPageId].price} kr.";

        logoImg.sprite = itemDataList[chosenPageId].largeImg;

        CheckIfAlreadySignedUp();
    }

    public void InstantiateItems2(int i)
    {
        chosenPageId = i;
    }


    private void CheckIfAlreadySignedUp()
    {
        // Check if the user is already signed up based on PlayerPrefs
        if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}") == 1)
        {
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().text = "Afmeld".ToUpper();
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().color = Color.red;
            tilmeldBtn.gameObject.GetComponent<Image>().color = new Color32(225, 225, 225, 255);
            signedUp = true;
        }
        else if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}") == 0)
        {
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().text = "Tilmeld".ToUpper();
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().color = Color.black;
            tilmeldBtn.gameObject.GetComponent<Image>().color = new Color32(131, 162, 137, 255);
            signedUp = false;
        }
    }

    public void TilmeldBtn()
    {
        if (!signedUp)
        {
            notificationManager.SendNotification("Du har tilmeldt dig aktiviteten!", false);
            PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}", 1);
            CheckIfAlreadySignedUp();
        }
        else if (signedUp)
        {
            notificationManager.SendNotification("Du har afmeldt dig aktiviteten!", true);
            PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}", 0);
            CheckIfAlreadySignedUp();
        }

        print(PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}"));
        PlayerPrefs.Save();
    }
}
